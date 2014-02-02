/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package service.siagie;

import java.util.HashMap;
import java.util.Map;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author JOAN CHAFLOQUE CANALES
 */
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
}