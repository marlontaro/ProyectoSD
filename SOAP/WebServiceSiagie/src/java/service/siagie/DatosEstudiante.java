/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package service.siagie;

import entidad.siagie.Alumno;
import entidad.siagie.DetalleNota;
 
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

@WebService(serviceName = "DatosEstudiante")
public class DatosEstudiante {

    @WebMethod(operationName = "datos")
    public String[] obtenerDatos(@WebParam(name = "dni") String dni) {
        // AP. PATERNO, AP.MATERNO, NOMBRES, FEC.NAC., ESTADO (P: Promovido, J: Repite, R: Retirado), NIVEL, GRADO, SECCION
        String[][] datosSiagie = new String [][] { 
            { "GONZALES", "HUAMAN", "Juan Carlos", "12/08/2000", "P", "S", "2", "A"},
            { "SANDOVAL", "AGUIRRE", "Renzo", "19/02/2000", "P", "S", "2", "A"},
            { "GALDOZ", "SEMINARIO", "Miegule", "12/08/2000", "P", "S", "3", "A"},
            { "CARPIO", "CAMPOS", "Maria Luisa", "24/05/2000", "J", "S", "3", "A"},
            { "SANTIAGO", "LOZA", "Fiorella", "18/04/2000", "R", "S", "4", "B"},
         };
        
        Map<String,String[]> hm = new HashMap<String,String[]>();   
        hm.put("12345601",datosSiagie[0]);
        hm.put("12345602",datosSiagie[1]);
        hm.put("12345603",datosSiagie[2]);
        hm.put("12345604",datosSiagie[3]);        
        
        return hm.get(dni);
    }
    
    @WebMethod(operationName = "notas")
    public String[] obtenerNotas(@WebParam(name = "dni") String dni) {
        //SN : SIN NOTA
        String[][] notas = new String [][] { 
            { "15", "16", "14", "20", "18", "16", "16", "14", "20", "18", "16"},
            { "15", "13", "12", "20", "13", "16", "16", "14", "20", "18", "16"},
            { "11", "13", "12", "19", "13", "16", "12", "14", "05", "18", "11"},
            { "11", "08", "12", "10", "14", "16", "12", "14", "05", "08", "11"},
            { "SN", "SN", "11", "10", "14", "16", "12", "14", "05", "08", "11"},
         };
        
        Map<String,String[]> hm = new HashMap<String,String[]>();   
        hm.put("12345601",notas[0]);
        hm.put("12345602",notas[1]);
        hm.put("12345603",notas[2]);
        hm.put("12345604",notas[3]);        
        
        return hm.get(dni);
    }
     
    @WebMethod(operationName = "ObtenerAlumno")
    public  Alumno ResultadoAlumno(@WebParam(name = "dni") String dni){
        List<Alumno> oListaDetalle = new ArrayList<Alumno>();
        Alumno oAlumno= new Alumno();
        
        oListaDetalle.add(new Alumno("12345601",  "GONZALES", "HUAMAN", "Juan Carlos", "12/08/2000", "Hombre", 
                                    2013, "Colegio ABC", "Secundaria", "2 Año", "Promovido"));
        
        oListaDetalle.add(new Alumno("12345602",  "SANDOVAL", "AGUIRRE", "Renzo", "19/02/2000", "Hombre", 
                                    2013, "Colegio ABC", "Secundaria", "2 Año", "Promovido"));
        
         oListaDetalle.add(new Alumno("12345603",  "GALDOZ", "SEMINARIO", "Miegule", "12/08/2000", "Hombre", 
                                    2013, "Colegio ABC", "Secundaria", "2 Año", "Promovido"));
         
        for(Alumno oEntidad : oListaDetalle){
            if(oEntidad.getDni().equalsIgnoreCase(dni)){
                oAlumno = oEntidad;break;
            }
        }
        
         return oAlumno;
    }
       
    @WebMethod(operationName = "ObtenerNotas")
    public  List<DetalleNota> ResultadoNotas(@WebParam(name = "dni") String dni){
        List<DetalleNota> oTemListaDetalle = new ArrayList<DetalleNota>();
        List<DetalleNota> oListaDetalle = new ArrayList<DetalleNota>();

        oTemListaDetalle.add(new DetalleNota("12345601", "Comunicacion Integral", "Aprobado", 13d));
        oTemListaDetalle.add(new DetalleNota("12345601", "Matenatica", "Aprobado", 14d));
        oTemListaDetalle.add(new DetalleNota("12345601", "Ciencias Naturales", "Aprobado", 13d));
        oTemListaDetalle.add(new DetalleNota("12345601", "Algebra", "Aprobado", 16d));
        
        oTemListaDetalle.add(new DetalleNota("12345602", "Comunicacion Integral", "Aprobado", 15d));
        oTemListaDetalle.add(new DetalleNota("12345602", "Matenatica", "Aprobado", 12d));
        oTemListaDetalle.add(new DetalleNota("12345602", "Ciencias Naturales", "Aprobado", 17d));
        oTemListaDetalle.add(new DetalleNota("12345602", "Algebra", "Aprobado", 13d));
        
        for(DetalleNota oEntidad : oTemListaDetalle){
            if(oEntidad.getDni().equalsIgnoreCase(dni)){
                oListaDetalle.add(oEntidad);break;
            }
        }
        
        return oListaDetalle;
    }    
  
     
}
