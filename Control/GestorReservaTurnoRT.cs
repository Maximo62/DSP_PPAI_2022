using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSI_PPAI.Entidades;
using DSI_PPAI.Boundary;
using DSI_PPAI.DTO;

namespace DSI_PPAI.Control
{
    public class GestorReservaTurnoRT
    {
        PantallaRegistrarTurnoRT pantallaRegistrarTurnoRT { get; set; }
        IList<TipoRecursoTecnologico> tipoRecursoTecnologicos { get; set; }
        TipoRecursoTecnologico tipoRecursoSeleccionado { get; set; }
        List<RecursoTecnologico> recursosActivos { get; set; }
        List<DTORecursoTecnologico> recursosActivosAMostrar { get; set; }
        


        public void nuevoTurnoRT(PantallaRegistrarTurnoRT pantallaRegistrarTurnoRT)
        {
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

        }

        //Aqui se hacen las "Consultas a la base" para obtener los objetos de cada clase

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
                new Modelo("AmScope M150C-I40X-1000X", "AmScope"),
                new CentroDeInvestigacion("Universidad Nacional de Cordoba", "UNC", "", "", 1, "", "35125556932", "unc@unc.edu.ar", 0, DateTime.Parse("15/02/1996"), "", "", DateTime.Parse(""), 5, DateTime.Parse(""), ""));

            var recurso2 = new RecursoTecnologico(
                2,
                DateTime.Parse("18/06/2022 15:22 PM"),
                new object(),
                3,
                2,
                2,
                cambiosEstadoRT.ToArray(),
                new TipoRecursoTecnologico("Resonador Magnético alta complejidad", ""),
                new Modelo("Ingenia Elition 3.0T", "Phillips"),
                new CentroDeInvestigacion("Universidad Nacional de Cordoba", "UNC", "", "", 1, "", "35125556932", "unc@unc.edu.ar", 0, DateTime.Parse("15/02/1996"), "", "", DateTime.Parse(""), 5, DateTime.Parse(""), ""));

            var recurso3 = new RecursoTecnologico(
                3,
                DateTime.Parse("12/06/2022 15:22 PM"),
                new object(),
                3,
                1,
                1,
                cambiosEstadoRT.ToArray(),
                new TipoRecursoTecnologico("Balanza de precisión analítica", ""),
                new Modelo("Serie A-300", "Krey"),
                new CentroDeInvestigacion("Universidad Nacional de Cordoba", "UNC", "", "", 1, "", "35125556932", "unc@unc.edu.ar", 0, DateTime.Parse("15/02/1996"), "", "", DateTime.Parse(""), 5, DateTime.Parse(""), ""));

            var lista = new List<RecursoTecnologico>();
            lista.Add(recurso1);
            lista.Add(recurso2);
            lista.Add(recurso3);
            return lista;
        }
    }
}
