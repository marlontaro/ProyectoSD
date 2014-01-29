
package pe.edu.upc.servicios;

import javax.ejb.Stateless;
import javax.ws.rs.Path;
import javax.ws.rs.GET;
import javax.ws.rs.Produces;
import javax.ws.rs.QueryParam;
import pe.edu.upc.dominio.Alumno;
import pe.edu.upc.dominio.GestorAlumno;

@Stateless
@Path("/alumno")
public class AlumnoService {

    private GestorAlumno gestorAlumno;
    
    public AlumnoService() {
        gestorAlumno = new GestorAlumno();
    }
    
    @GET
    @Produces({"application/xml"})
    public Alumno buscarAlumnoPorDNI(@QueryParam("dni") String dni) {
        return gestorAlumno.buscarPorDNI(dni);
    }

}
