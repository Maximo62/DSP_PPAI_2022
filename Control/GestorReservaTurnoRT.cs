using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.Entidades;
using DSI_PPAI.Boundary;
using DSI_PPAI.DTO;
using DSI_PPAI.Boundary.InterfacesNotificacion;

namespace DSI_PPAI.Control
{
    public class GestorReservaTurnoRT
    {
        PantallaRegistrarTurnoRT pantallaRegistrarTurnoRT { get; set; }
        IList<TipoRecursoTecnologico> tipoRecursoTecnologicos { get; set; }
        TipoRecursoTecnologico tipoRecursoSeleccionado { get; set; }
        List<RecursoTecnologico> recursosActivos { get; set; }
        List<DTORecursoTecnologico> recursosActivosAMostrar { get; set; }
        RecursoTecnologico? recursoSeleccionado { get; set; }
        Sesion sesionActual { get; set; }
        PersonalCientifico cientificoLogueado { get; set; }
        DateTime fechaHoraActual { get; set; }
        List<Turno> turnosDeRecurso { get; set; }
        List<DTOTurno> turnosDeRecursoSeleccionado { get; set; }
        Turno turnoSeleccionado { get; set; }
        DTORecursoTecnologico datosAMostrarRecursoTecnologicoSeleccionado { get; set; }
        List<TipoNotificacion> tiposNotificacion { get; set; }
        List<Estado> estados { get; set; }
        Estado estadoReservado { get; set; }
        DTOConfirmacionReserva datosReserva { get; set; }
        


        public void nuevoTurnoRT(PantallaRegistrarTurnoRT pantallaRegistrarTurnoRT)
        {
            this.sesionActual = new Sesion(DateTime.Now, new Usuario("123456", "lopez.marcelo", true, new PersonalCientifico(888111, "Marcelo", "Lopez", 20225885, "", "", 0, null)));
            this.pantallaRegistrarTurnoRT = pantallaRegistrarTurnoRT;
            this.buscarTiposRT();
            
        }

        public void buscarTiposRT()
        {
            this.tipoRecursoTecnologicos = this.obtenerTiposRecursoTecnologico();
            List<string> vectorTiposRT = new List<string>();

            foreach (TipoRecursoTecnologico tipo in this.tipoRecursoTecnologicos)
            {
                vectorTiposRT.Add(tipo.Nombre);
            }

            this.pantallaRegistrarTurnoRT.pedirSeleccionTipoRT(vectorTiposRT.ToArray());
            
        }

        

        public void tomarSeleccionTipoRT(int indice)
        {
            this.tipoRecursoSeleccionado = tipoRecursoTecnologicos[indice];
            this.buscarRTActivos(tipoRecursoSeleccionado);
            
        }

        public void buscarRTActivos(TipoRecursoTecnologico tipoRecurso)
        {
            this.recursosActivos = new List<RecursoTecnologico>();
            var recursos = obtenerRecursosTecnologicos();
            foreach (RecursoTecnologico recurso in recursos)
            {
                if(recurso.esTuTipoRT(tipoRecurso.Nombre))
                {
                    this.recursosActivos.Add(recurso);
                }
            }
            this.buscarDatosRTActivos();
             
        }

        public void buscarDatosRTActivos()
        {
            this.recursosActivosAMostrar = new List<DTORecursoTecnologico>();
            foreach (RecursoTecnologico recurso in this.recursosActivos)
            {
                var recursoAMostrar = new DTORecursoTecnologico();
                recursoAMostrar.NumeroRT = recurso.NumeroRT;
                recursoAMostrar.NombreCentroDeInvestigacion = recurso.getCentroDeInvestigacion();
                recursoAMostrar.NombreEstadoActual = recurso.getEstadoActual();
                recursoAMostrar.ModeloYMarca = recurso.getModeloYMarca();

                this.recursosActivosAMostrar.Add(recursoAMostrar);
            }
            this.pantallaRegistrarTurnoRT.mostrarDatosRTActivos(this.recursosActivosAMostrar);

        }

        public void tomarSeleccionRT(DTORecursoTecnologico recursoSeleccionado)
        {
            this.datosAMostrarRecursoTecnologicoSeleccionado = recursoSeleccionado;
            this.recursoSeleccionado = recursosActivos.FirstOrDefault(rec => rec.NumeroRT.Equals(recursoSeleccionado.NumeroRT));
            this.validarCICientificoRT();
        }

        public void validarCICientificoRT()
        {
            this.cientificoLogueado = this.sesionActual.obtenerUsuarioLogueado();

            if (this.recursoSeleccionado.esCientificoDeCI(this.cientificoLogueado))
            {
                this.obtenerFechaHoraActual();
            }
            else
            {
                this.pantallaRegistrarTurnoRT.mostrarErrorCientifico();
            }
            
        }

        public void obtenerFechaHoraActual()
        {
            this.fechaHoraActual = DateTime.Now;
            this.obtenerTurnosRT();
        }

        public void obtenerTurnosRT()
        {
            this.turnosDeRecurso = this.obtenerTurnos(this.recursoSeleccionado);
            this.turnosDeRecursoSeleccionado = this.recursoSeleccionado.getTurnosRT(this.fechaHoraActual);

            if (this.turnosDeRecursoSeleccionado.Count > 0)
            {
                pantallaRegistrarTurnoRT.mostrarTurnosDisponibles(this.turnosDeRecursoSeleccionado);
            }
            else
            {
                pantallaRegistrarTurnoRT.mostrarErrorSinTurnos();
            }
        }

        public void tomarSeleccionTurno(DTOTurno turnoSeleccionado)
        {
            this.turnoSeleccionado = this.turnosDeRecurso.FirstOrDefault(turno => turno.NroTurno.Equals(turnoSeleccionado.NroTurno));
            DTOConfirmacionReserva datosConfirmacion = new DTOConfirmacionReserva();
            datosConfirmacion.NumeroRT = datosAMostrarRecursoTecnologicoSeleccionado.NumeroRT.ToString();
            datosConfirmacion.NombreTipo = recursoSeleccionado.getNombreTipoRT();
            datosConfirmacion.NombreCI = datosAMostrarRecursoTecnologicoSeleccionado.NombreCentroDeInvestigacion;
            datosConfirmacion.ModeloYMarca = datosAMostrarRecursoTecnologicoSeleccionado.ModeloYMarca;
            datosConfirmacion.FechaHoraInicio = turnoSeleccionado.FechaHoraInicio;
            datosConfirmacion.FechaHoraFin = turnoSeleccionado.FechaHoraFin;
            datosConfirmacion.DiaSemana = turnoSeleccionado.DiaSemana;
            datosConfirmacion.NombreYApellido = cientificoLogueado.Apellido + ", " + cientificoLogueado.Nombre;
            datosConfirmacion.Legajo = cientificoLogueado.Legajo.ToString();
            this.datosReserva = datosConfirmacion;

            List<string> listaTipos = new List<string>();
            this.tiposNotificacion = obtenerTiposNotificacion();
            this.tiposNotificacion.ForEach(tipo => listaTipos.Add(tipo.Nombre));


            pantallaRegistrarTurnoRT.solicitarConfirmacionReserva(datosConfirmacion, listaTipos);
        }

        public void tomarConfirmacionReserva(DTOConfirmacionReserva datosConfirmacion, int indiceTipoNotificacion)
        {
            TipoNotificacion tipoNotificacionSeleccionado = this.tiposNotificacion[indiceTipoNotificacion];
            this.reservarTurno();
        }

        public void reservarTurno()
        {
            this.estados = obtenerEstados();
            foreach (Estado estado in this.estados)
            {
                if (estado.esAmbitoTurno())
                {
                    if (estado.sosReservable())
                    {
                        this.estadoReservado = estado;
                        this.turnoSeleccionado.reservar(this.fechaHoraActual, this.estadoReservado);
                        this.enviarNotifMail();
                    }
                }
            }
        }

        private void enviarNotifMail()
        {
            NotificacionMail mail = new NotificacionMail();
            INotificacion interfazNotificacionMail = mail;
            interfazNotificacionMail.enviarNotificacion(this.datosReserva);

            this.pantallaRegistrarTurnoRT.Show();

            this.finCU();
        }

        private void finCU()
        {
            pantallaRegistrarTurnoRT.mostrarMensaje("La reserva se realizó con éxito");
            pantallaRegistrarTurnoRT.ocultarPantalla();
        }

        //Aqui se hacen las "Consultas a la base" para obtener los objetos de cada clase

        public List<Estado> obtenerEstados()
        {
            List<Estado> estados = new List<Estado>();
            var estado1 = new Estado("Generado", "", "Turno", true, false);
            var estado2 = new Estado("Ingresado", "", "RecursoTecnologico", true, false);
            var estado3 = new Estado("Reservado", "", "Turno", false, true);

            estados.Add(estado1);
            estados.Add(estado2);
            estados.Add(estado3);

            return estados;
        }

        public List<TipoNotificacion> obtenerTiposNotificacion()
        {
            var lista = new List<TipoNotificacion>();
            var tipo1 = new TipoNotificacion(1, "Mail", "");
            var tipo2 = new TipoNotificacion(2, "WhatsApp", "");
            lista.Add(tipo1);
            lista.Add(tipo2);

            return lista;
        }

        public List<TipoRecursoTecnologico> obtenerTiposRecursoTecnologico()
        {
            var lista = new List<TipoRecursoTecnologico>();
            var tipo1 = new TipoRecursoTecnologico("Microscopio de contraste de fases", "");
            var tipo2 = new TipoRecursoTecnologico("Resonador Magnético alta complejidad", "");
            var tipo3 = new TipoRecursoTecnologico("Balanza de precisión analítica", "");
            lista.Add(tipo1);
            lista.Add(tipo2);
            lista.Add(tipo3);

            return lista;
        }

        public List<Turno> obtenerTurnos(RecursoTecnologico recursoSeleccionado)
        {
            List<Turno> turnosDeRecurso = new List<Turno>();
            var cambiosEstadoTurno = new List<CambioEstadoTurno>();
            cambiosEstadoTurno.Add(new CambioEstadoTurno(DateTime.Parse("01/06/2022 08:00 AM"), new Estado("Generado", "", "Turno", true, false)));

            turnosDeRecurso.Add(new Turno(DateTime.Parse("01/06/2022"), "Lunes", DateTime.Parse("27/06/2022 08:00 AM"), DateTime.Parse("27/06/2022 11:00 AM"), cambiosEstadoTurno, 1));
            turnosDeRecurso.Add(new Turno(DateTime.Parse("01/06/2022"), "Martes", DateTime.Parse("28/06/2022 08:00 AM"), DateTime.Parse("28/06/2022 11:00 AM"), cambiosEstadoTurno, 2));
            turnosDeRecurso.Add(new Turno(DateTime.Parse("01/06/2022"), "Miercoles", DateTime.Parse("29/06/2022 08:00 AM"), DateTime.Parse("29/06/2022 11:00 AM"), cambiosEstadoTurno, 3));
            turnosDeRecurso.Add(new Turno(DateTime.Parse("01/06/2022"), "Jueves", DateTime.Parse("30/06/2022 08:00 AM"), DateTime.Parse("30/06/2022 11:00 AM"), cambiosEstadoTurno, 4));
            turnosDeRecurso.Add(new Turno(DateTime.Parse("01/06/2022"), "Viernes", DateTime.Parse("01/07/2022 08:00 AM"), DateTime.Parse("01/07/2022 11:00 AM"), cambiosEstadoTurno, 5));


            this.recursoSeleccionado.Turnos = turnosDeRecurso;

            return turnosDeRecurso;
        }

        public List<RecursoTecnologico> obtenerRecursosTecnologicos()
        {
            var cambiosEstadoRT = new List<CambioEstadoRT>();
            cambiosEstadoRT.Add(new CambioEstadoRT(DateTime.Parse("15/06/2022"), new Estado("Ingresado", "", "Recurso Tecnologico", true, false)));

            var recurso1 = new RecursoTecnologico(
                1,
                DateTime.Parse("20/06/2022 15:22 PM"),
                new object(),
                2,
                1,
                1,
                cambiosEstadoRT.ToArray(),
                new TipoRecursoTecnologico("Microscopio de contraste de fases", ""),
                new Modelo("AmScope M150C-I40X-1000X", "AmScope"));
                recurso1.CentroDeInvestigacion = new CentroDeInvestigacion("Universidad Nacional de Cordoba", "UNC", "", "", 1, "", "35125556932", "unc@unc.edu.ar", 0, DateTime.Parse("15/02/1996"), "", "", DateTime.Parse("15/02/1996"), 5, "");
                List<AsignacionCientificoDelCI> cientificos = new List<AsignacionCientificoDelCI>();
                cientificos.Add(new AsignacionCientificoDelCI(DateTime.Parse("27/02/1995"), new PersonalCientifico(888111, "Marcelo", "Lopez", 20225885, "", "", 0, null)));
                recurso1.CentroDeInvestigacion.Cientificos = cientificos;

            var recurso2 = new RecursoTecnologico(
                2,
                DateTime.Parse("18/06/2022 15:22 PM"),
                new object(),
                3,
                2,
                2,
                cambiosEstadoRT.ToArray(),
                new TipoRecursoTecnologico("Resonador Magnético alta complejidad", ""),
                new Modelo("Ingenia Elition 3.0T", "Phillips"));
                recurso2.CentroDeInvestigacion = new CentroDeInvestigacion("Universidad Nacional de Cordoba", "UNC", "", "", 1, "", "35125556932", "unc@unc.edu.ar", 0, DateTime.Parse("15/02/1996"), "", "", DateTime.Parse("15/02/1996"), 5, "");
                List<AsignacionCientificoDelCI> cientificos2 = new List<AsignacionCientificoDelCI>();
                cientificos2.Add(new AsignacionCientificoDelCI(DateTime.Parse("27/02/1995"), new PersonalCientifico(888111, "Marcelo", "Lopez", 20225885, "", "", 0, null)));
                recurso2.CentroDeInvestigacion.Cientificos = cientificos2;


            var recurso3 = new RecursoTecnologico(
                3,
                DateTime.Parse("12/06/2022 15:22 PM"),
                new object(),
                3,
                1,
                1,
                cambiosEstadoRT.ToArray(),
                new TipoRecursoTecnologico("Balanza de precisión analítica", ""),
                new Modelo("Serie A-300", "Krey"));
                recurso3.CentroDeInvestigacion = new CentroDeInvestigacion("Universidad Nacional de Cordoba", "UNC", "", "", 1, "", "35125556932", "unc@unc.edu.ar", 0, DateTime.Parse("15/02/1996"), "", "", DateTime.Parse("15/02/1996"), 5, "");
                List<AsignacionCientificoDelCI> cientificos3 = new List<AsignacionCientificoDelCI>();
                cientificos3.Add(new AsignacionCientificoDelCI(DateTime.Parse("27/02/1995"), new PersonalCientifico(888111, "Marcelo", "Lopez", 20225885, "", "", 0, null)));
                recurso3.CentroDeInvestigacion.Cientificos = cientificos3;


            var recurso4 = new RecursoTecnologico(
                4,
                DateTime.Parse("15/04/2022 15:20 PM"),
                new object(),
                2,
                1,
                1,
                cambiosEstadoRT.ToArray(),
                new TipoRecursoTecnologico("Microscopio de contraste de fases", ""),
                new Modelo("AmScope M150C-I40X-1000X - E", "AmScope"));
                recurso4.CentroDeInvestigacion = new CentroDeInvestigacion("Universidad Nacional de Cordoba", "UNC", "", "", 1, "", "35125556932", "unc@unc.edu.ar", 0, DateTime.Parse("15/02/1996"), "", "", DateTime.Parse("15/02/1996"), 5, "");
                List<AsignacionCientificoDelCI> cientificos4 = new List<AsignacionCientificoDelCI>();
                cientificos4.Add(new AsignacionCientificoDelCI(DateTime.Parse("27/02/1995"), new PersonalCientifico(888111, "Marcelo", "Lopez", 20225885, "", "", 0, null)));
                recurso4.CentroDeInvestigacion.Cientificos = cientificos4;


            var recurso5 = new RecursoTecnologico(
                5,
                DateTime.Parse("21/01/2022 15:22 PM"),
                new object(),
                2,
                1,
                1,
                cambiosEstadoRT.ToArray(),
                new TipoRecursoTecnologico("Microscopio de contraste de fases", ""),
                new Modelo("Arcano Xsp-104", "Arcano"));
                recurso5.CentroDeInvestigacion = new CentroDeInvestigacion("Universidad Nacional de Cordoba", "UNC", "", "", 1, "", "35125556932", "unc@unc.edu.ar", 0, DateTime.Parse("15/02/1996"), "", "", DateTime.Parse("15/02/1996"), 5, "");
                List<AsignacionCientificoDelCI> cientificos5 = new List<AsignacionCientificoDelCI>();
                cientificos5.Add(new AsignacionCientificoDelCI(DateTime.Parse("27/02/1995"), new PersonalCientifico(888111, "Marcelo", "Lopez", 20225885, "", "", 0, null)));
                recurso5.CentroDeInvestigacion.Cientificos = cientificos5;


            var recurso6 = new RecursoTecnologico(
                6,
                DateTime.Parse("21/01/2022 15:22 PM"),
                new object(),
                2,
                1,
                1,
                cambiosEstadoRT.ToArray(),
                new TipoRecursoTecnologico("Microscopio de contraste de fases", ""),
                new Modelo("XS2-35", "Phillips"));
                recurso6.CentroDeInvestigacion = new CentroDeInvestigacion("Universidad Tecnologica Nacional - Regional Cordoba", "UTN - FRC", "", "", 1, "", "3514456669", "utn@frc.utn.edu.ar", 0, DateTime.Parse("15/01/1998"), "", "", DateTime.Parse("15/01/1998"), 5, "");
                List<AsignacionCientificoDelCI> cientificos6 = new List<AsignacionCientificoDelCI>();
                cientificos6.Add(new AsignacionCientificoDelCI(DateTime.Parse("12/02/1990"), new PersonalCientifico(758889, "Carlos", "Saavedra", 15112887, "", "", 0, null)));
                recurso6.CentroDeInvestigacion.Cientificos = cientificos6;

            var lista = new List<RecursoTecnologico>();
            lista.Add(recurso1);
            lista.Add(recurso2);
            lista.Add(recurso3);
            lista.Add(recurso4);
            lista.Add(recurso5);
            lista.Add(recurso6);
            return lista;
        }
    }
}
