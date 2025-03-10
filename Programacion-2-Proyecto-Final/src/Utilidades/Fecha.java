package Utilidades;

import java.time.LocalDate;
import java.time.Period;
import java.time.format.DateTimeFormatter;

public class Fecha {

    private final DateTimeFormatter fmt = DateTimeFormatter.ofPattern("dd/MM/yyyy");
    private Period periodo;
    private LocalDate fecha;
    private LocalDate fechaActu;

    public Fecha(String fecha) {
        this.fechaActu = LocalDate.now();
        this.setFecha(fecha);
    }



    /**
     * Se ingresa la fecha de nacimiento de la Persona.
     *
     * @param fecha dd/MM/yyyy
     */
    public void setFecha(String fecha) {
        this.fecha = LocalDate.parse(fecha, fmt);
    }

    public LocalDate getFecha() {
        return fecha;
    }

    /**
     * Calcula la edad de la Persona.
     *
     * @param fecha
     */
    public void setPeriodo(LocalDate fecha) {
        this.periodo = Period.between(fecha, fechaActu);
    }

    public Period getPeriodo() {
        return periodo;
    }
}
