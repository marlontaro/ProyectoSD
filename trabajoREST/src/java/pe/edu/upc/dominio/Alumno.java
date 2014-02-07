package pe.edu.upc.dominio;

import java.util.Date;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;
import javax.xml.bind.annotation.XmlTransient;

@XmlRootElement
@XmlType(propOrder = {"dni","apellidoPaterno","apellidoMaterno","nombres","fechaNacimiento","ubigeo","sexo","madre","dniMadre","padre","dniPadre","direccion","distrito","provincia","departamento"})    
public class Alumno{
    
    private String dni;
    private String apellidoPaterno;
    private String apellidoMaterno;
    private String nombres;
    private String direccion;
    private Date fechaNacimiento;
    private String padre;
    private String madre;
    private String dniPadre;
    private String dniMadre;
    private String ubigeo;
    private String sexo;
    private String distrito;
    private String provincia;
    private String departamento;
    
    public Alumno() {
    }

    public Alumno(String dni, String apellidoPaterno, String apellidoMaterno, String nombres, String direccion, Date fechaNacimiento,String padre,String madre, String dniPadre, String dniMadre, String ubigeo,String sexo,String distrito, String provincia, String departamento) {
        this.dni = dni;
        this.apellidoPaterno = apellidoPaterno;
        this.apellidoMaterno = apellidoMaterno;
        this.nombres = nombres;
        this.direccion = direccion;
        this.fechaNacimiento = fechaNacimiento;
        this.padre = padre;
        this.madre = madre;
        this.dniPadre = dniPadre;
        this.dniMadre = dniMadre;
        this.ubigeo = ubigeo;
        this.sexo = sexo;
        this.distrito = distrito;
        this.provincia = provincia;
        this.departamento = departamento;
    }

  
    
    public String getDni() {
        return dni;
    }
   
    public void setDni(String dni) {
        this.dni = dni;
    }

    
    public String getApellidoPaterno() {
        return apellidoPaterno;
    }

    public void setApellidoPaterno(String apellidoPaterno) {
        this.apellidoPaterno = apellidoPaterno;
    }

    
    public String getApellidoMaterno() {
        return apellidoMaterno;
    }

    public void setApellidoMaterno(String apellidoMaterno) {
        this.apellidoMaterno = apellidoMaterno;
    }

    
    public String getNombres() {
        return nombres;
    }

    public void setNombres(String nombres) {
        this.nombres = nombres;
    }

    
    public String getDireccion() {
        return direccion;
    }
    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }
    
    @XmlElement(name = "fecha_nacimiento")
    public Date getFechaNacimiento() {
        return fechaNacimiento;
    }
    public void setFechaNacimiento(Date fechaNacimiento) {
        this.fechaNacimiento = fechaNacimiento;
    }
   
    public String getPadre() {
        return padre;
    }
    public void setPadre(String padre) {
        this.padre = padre;
    }
    
    public String getMadre() {
        return madre;
    }
    public void setMadre(String madre) {
        this.madre = madre;
    }
    
    public String getDniPadre() {
        return dniPadre;
    }
    public void setDniPadre(String dniPadre) {
        this.dniPadre = dniPadre;
    }
 
    public String getDniMadre() {
        return dniMadre;
    }
    public void setDniMadre(String dniMadre) {
        this.dniMadre = dniMadre;
    }
 
    public String getUbigeo() {
        return ubigeo;
    }
    public void setUbigeo(String ubigeo) {
        this.ubigeo = ubigeo;
    }
       
    public String getSexo() {
        return sexo;
    }
    public void setSexo(String sexo) {
        this.sexo = sexo;
    }
 
    public String getDistrito() {
        return distrito;
    }
    public void setDistrito(String distrito) {
        this.distrito = distrito;
    }
      
    public String getProvincia() {
        return provincia;
    }
    public void setProvincia(String provincia) {
        this.provincia = provincia;
    }
      
    public String getDepartamento() {
        return departamento;
    }
    public void setDepartamento(String departamento) {
        this.departamento = departamento;
    } 
}
