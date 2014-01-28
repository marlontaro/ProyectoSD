/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package service.siagie;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author JOAN
 */
@WebService(serviceName = "DatosEstudiante")
public class DatosEstudiante {
   
    @WebMethod(operationName = "datos")
    public String[] obtenerDatos(@WebParam(name = "name") int codigo) {
         String[][] datosSiagie = new String [][] { 
            { "12345678", "GONZALES", "HUAMAN", "Juan Carlos", "12/08/1995"},
            { "52344567", "SANDOVAL", "AGUIRRE", "Renzo", "19/02/1997"},
            { "87657895", "GALDOZ", "SEMINARIO", "Miegule", "12/08/1995"},
            { "56892341", "CARPIO", "CAMPOS", "Maria Luisa", "24/05/1993"},
            { "98598038", "SANTIAGO", "LOZA", "Fiorella", "18/04/1990"},
         };
        return datosSiagie[codigo];
    }
}
