package pe.edu.upc.dominio;


import java.util.GregorianCalendar;
import java.util.HashMap;
import java.util.Map;

public class GestorAlumno {
    
    private Map<String,Alumno> alumnos;

    public GestorAlumno() {
        alumnos = new HashMap<>();
        
        Alumno alumno1 = new Alumno("40806193","YACCHI","MENDEZ","VANS URBANO","JR NECOCHEA 160",(new GregorianCalendar(1980,11,25).getTime()),"URBANO YACCHI", "ZOILA MENDEZ","06057115","07555412","140133","M","RIMAC", "LIMA", "LIMA");
        Alumno alumno2 = new Alumno("40647590","CHAVEZ","REYES","RICHARD","AV. BALSAS 3-A",(new GregorianCalendar(1980,11,25).getTime()),"MARCELO MARINO CHAVEZ HUAYLLA", "CARMEN ROSA REYES SANTAMARIA","06433568","06898640","198456","M","CHORRILLOS","LIMA","LIMA");
        Alumno alumno3 = new Alumno("40647591","CHAVEZ","REYES","RICHARD","AV. BALSAS 3-A",(new GregorianCalendar(1980,11,25).getTime()),"MARCELO MARINO CHAVEZ HUAYLLA", "CARMEN ROSA REYES SANTAMARIA","06433568","06898640","198456","M","CHORRILLOS","LIMA","LIMA");
        
        alumnos.put("40806193", alumno1);
        alumnos.put("40647590", alumno2);
        alumnos.put("40647591", alumno3);
    }
    public Alumno buscarPorDNI(String dni){
        return alumnos.get(dni);
    }
    
}

