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
            { "12345678", "GONZALES", "HUAMAN", "Juan Carlos", "12/08/2000"},
            { "52344567", "SANDOVAL", "AGUIRRE", "Renzo", "19/02/2000"},
            { "87657895", "GALDOZ", "SEMINARIO", "Miegule", "12/08/2000"},
            { "56892341", "CARPIO", "CAMPOS", "Maria Luisa", "24/05/2000"},
            { "98598038", "SANTIAGO", "LOZA", "Fiorella", "18/04/2000"},
         };
        return datosSiagie[codigo];
    }
    
    public String[] obtenerHistorial(@WebParam(name = "name") int codigo) {
         String[][] data = new String [][] {
                {"2013", "S", "4", "A", "Champagnat", "P"}, 
                {"2013", "S", "4", "B", "Recoleta", "P"}, 
                {"2013", "S", "4", "C", "Santísimo Nombre de Jesús", "J"}, 
                {"2013", "S", "3", "A", "Nuestra Sr. del Consuelo", "R"}, 
                {"2013", "S", "3", "A", "San José de Monterrico", "P"},
                {"2013", "S", "3", "A", "Santa Rita de Casia", "P"}
         };
        return data[codigo];
    }
    
    
}
