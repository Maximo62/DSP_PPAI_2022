﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PPAI.Entidades
{
    public class AsignacionCientificoDelCI
    {
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private PersonalCientifico personalCientifico;

        public AsignacionCientificoDelCI(DateTime fechaDesde, PersonalCientifico personalCientifico)
        {
            this.fechaDesde = fechaDesde;
            this.personalCientifico = personalCientifico;
        }

        public DateTime FechaDesde { get => fechaDesde; set => fechaDesde = value; }
        public DateTime FechaHasta { get => fechaHasta; set => fechaHasta = value; }
        public PersonalCientifico PersonalCientifico { get => personalCientifico ; set => personalCientifico = value; }

        public bool esTuCientifico(PersonalCientifico cientificoLogueado)
        {
            return this.personalCientifico.Legajo.Equals(cientificoLogueado.Legajo);
        }
    }
}
    