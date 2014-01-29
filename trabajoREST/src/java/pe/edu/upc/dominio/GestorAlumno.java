package pe.edu.upc.dominio;


import java.util.GregorianCalendar;
import java.util.HashMap;
import java.util.Map;

public class GestorAlumno {
    
    private Map<String,Alumno> alumnos;

    public GestorAlumno() {
        alumnos = new HashMap<>();
        
        Alumno alumno1 = new Alumno("40806193","YACCHI","MENDEZ","VANS","JR NECOCHEA 160, RIMAC","LIMA", "PERU",(new GregorianCalendar(1980,11,25).getTime()));
        Alumno alumno2 = new Alumno("40647590","CHAVEZ","REYES","RICHARD","AV BALSAS MZ A LOTE 3, CHORRILLOS","LIMA", "PERU",(new GregorianCalendar(1980,06,14).getTime()));
        
        alumnos.put("40806193", alumno1);
        alumnos.put("40647590", alumno2);
    }
    
    public Alumno buscarPorDNI(String dni){
        return alumnos.get(dni);
    }
    
}

