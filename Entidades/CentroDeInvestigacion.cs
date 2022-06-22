namespace DSI_PPAI.Entidades
{
    public class CentroDeInvestigacion
    {
        private string nombre;
        private string sigla;
        private string direccion;
        private string edificio;
        private int piso;
        private string coordenadas;
        private string telefonosContacto;
        private string correoElectronico;
        private int numeroResolucionCreacion;
        private DateTime fechaResolucionCreacion;
        private string reglamento;
        private string caracteristicasGenerales;
        private DateTime fechaAlta;
        private int tiempoAntelacionReserva;
        private DateTime? fechaBaja = null;
        private string motivoBaja;
        private RecursoTecnologico[] recursoTecnologicos;
        private List<AsignacionCientificoDelCI> cientificos;

        // Constructor sin RT ni Asignacion
        public CentroDeInvestigacion(string nombre, string sigla, string direccion, string edificio, int piso, string coordenadas, string telefonosContacto, string correoElectronico, int numeroResolucionCreacion, DateTime fechaResolucionCreacion, string reglamento, string caracteristicasGenerales, DateTime fechaAlta, int tiempoAntelacionReserva, string motivoBaja)
        {
            this.nombre = nombre;
            this.sigla = sigla;
            this.direccion = direccion;
            this.edificio = edificio;
            this.piso = piso;
            this.coordenadas = coordenadas;
            this.telefonosContacto = telefonosContacto;
            this.correoElectronico = correoElectronico;
            this.numeroResolucionCreacion = numeroResolucionCreacion;
            this.fechaResolucionCreacion = fechaResolucionCreacion;
            this.reglamento = reglamento;
            this.caracteristicasGenerales = caracteristicasGenerales;
            this.fechaAlta = fechaAlta;
            this.tiempoAntelacionReserva = tiempoAntelacionReserva;
            this.motivoBaja = motivoBaja;
        }

        // Constructor sin RT
        public CentroDeInvestigacion(string nombre, string sigla, string direccion, string edificio, int piso, string coordenadas, string telefonosContacto, string correoElectronico, int numeroResolucionCreacion, DateTime fechaResolucionCreacion, string reglamento, string caracteristicasGenerales, DateTime fechaAlta, int tiempoAntelacionReserva, string motivoBaja, List<AsignacionCientificoDelCI> cientificos)
        {
            this.nombre = nombre;
            this.sigla = sigla;
            this.direccion = direccion;
            this.edificio = edificio;
            this.piso = piso;
            this.coordenadas = coordenadas;
            this.telefonosContacto = telefonosContacto;
            this.correoElectronico = correoElectronico;
            this.numeroResolucionCreacion = numeroResolucionCreacion;
            this.fechaResolucionCreacion = fechaResolucionCreacion;
            this.reglamento = reglamento;
            this.caracteristicasGenerales = caracteristicasGenerales;
            this.fechaAlta = fechaAlta;
            this.tiempoAntelacionReserva = tiempoAntelacionReserva;
            this.motivoBaja = motivoBaja;
            this.cientificos = cientificos;
        }
        // Constructor sin AsignacionCientificoDelCI
        public CentroDeInvestigacion(string nombre, string sigla, string direccion, string edificio, int piso, string coordenadas, string telefonosContacto, string correoElectronico, int numeroResolucionCreacion, DateTime fechaResolucionCreacion, string reglamento, string caracteristicasGenerales, DateTime fechaAlta, int tiempoAntelacionReserva, string motivoBaja, RecursoTecnologico[] recursoTecnologicos)
        {
            this.nombre = nombre;
            this.sigla = sigla;
            this.direccion = direccion;
            this.edificio = edificio;
            this.piso = piso;
            this.coordenadas = coordenadas;
            this.telefonosContacto = telefonosContacto;
            this.correoElectronico = correoElectronico;
            this.numeroResolucionCreacion = numeroResolucionCreacion;
            this.fechaResolucionCreacion = fechaResolucionCreacion;
            this.reglamento = reglamento;
            this.caracteristicasGenerales = caracteristicasGenerales;
            this.fechaAlta = fechaAlta;
            this.tiempoAntelacionReserva = tiempoAntelacionReserva;
            this.motivoBaja = motivoBaja;
            this.recursoTecnologicos = recursoTecnologicos;
        }
        // Constructor completo
        public CentroDeInvestigacion(
            string nombre,
            string sigla,
            string direccion,
            string edificio,
            int piso,
            string coordenadas,
            string telefonosContacto,
            string correoElectronico,
            int numeroResolucionCreacion,
            DateTime fechaResolucionCreacion,
            string reglamento,
            string caracteristicasGenerales,
            DateTime fechaAlta,
            int tiempoAntelacionReserva,
            DateTime fechaBaja,
            string motivoBaja,
            RecursoTecnologico[] recursoTecnologicos,
            List<AsignacionCientificoDelCI> cientificos)
        {
            this.Nombre = nombre;
            this.Sigla = sigla;
            this.Direccion = direccion;
            this.Edificio = edificio;
            this.Piso = piso;
            this.Coordenadas = coordenadas;
            this.TelefonosContacto = telefonosContacto;
            this.CorreoElectronico = correoElectronico;
            this.NumeroResolucionCreacion = numeroResolucionCreacion;
            this.FechaResolucionCreacion = fechaResolucionCreacion;
            this.Reglamento = reglamento;
            this.CaracteristicasGenerales = caracteristicasGenerales;
            this.FechaAlta = fechaAlta;
            this.TiempoAntelacionReserva = tiempoAntelacionReserva;
            this.FechaBaja = fechaBaja;
            this.MotivoBaja = motivoBaja;
            this.RecursoTecnologicos = recursoTecnologicos;
            this.Cientificos = cientificos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Edificio { get => edificio; set => edificio = value; }
        public int Piso { get => piso; set => piso = value; }
        public string Coordenadas { get => coordenadas; set => coordenadas = value; }
        public string TelefonosContacto { get => telefonosContacto; set => telefonosContacto = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public int NumeroResolucionCreacion { get => numeroResolucionCreacion; set => numeroResolucionCreacion = value; }
        public DateTime FechaResolucionCreacion { get => fechaResolucionCreacion; set => fechaResolucionCreacion = value; }
        public string Reglamento { get => reglamento; set => reglamento = value; }
        public string CaracteristicasGenerales { get => caracteristicasGenerales; set => caracteristicasGenerales = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public int TiempoAntelacionReserva { get => tiempoAntelacionReserva; set => tiempoAntelacionReserva = value; }
        public DateTime FechaBaja { get => (DateTime)fechaBaja; set => fechaBaja = value; }
        public string MotivoBaja { get => motivoBaja; set => motivoBaja = value; }
        public RecursoTecnologico[] RecursoTecnologicos { get => recursoTecnologicos; set => recursoTecnologicos = value; }
        public List<AsignacionCientificoDelCI> Cientificos { get => cientificos; set => cientificos = value; }

        public bool esCientificoDeCI(PersonalCientifico cientificoLogueado)
        {
            foreach (AsignacionCientificoDelCI cientifico in this.cientificos)
            {
                return cientifico.esTuCientifico(cientificoLogueado);
            }
            return false;
        }
    }
}
