using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	private int numeroRT;
	private DateTime fechaAlta;
	private var imagen;
	private int periodicidadMantenimientoPrev;
	private int duracionMantenimientoPrev;
	private int fraccionHorarioTurnos;


	public int getNumeroRT() { return this.numeroRT;}
	public int setNumeroRT(var) { this.numeroRT = var; }

	public int getFechaAlta() { return this.fechaAlta; }
	public int setFechaAlta(var){ this.fechaAlta = var; }



	public int getPeriodicidadMantenimientoPrev(){ return this.PeriodicidadMantenimientoPrev; }
	public int setPeriodicidadMantenimientoPrev(var) { this.PeriodicidadMantenimientoPrev = var; }

	public int getDuracionMantenimientoPrev() { return this.duracionMantenimientoPrev; }
	public int setDuracionMantenimientoPrev(var) { this.duracionMantenimientoPrev = var; }

	public int getFraccionHorarioTurnos() { return this.duracionMantenimientoPrev; }
	public int setFraccionHorarioTurnos(var) { this.duracionMantenimientoPrev = var; }

}
