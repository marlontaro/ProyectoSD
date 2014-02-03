package entidad.siagie;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;

@XmlType(name = "Alumno")
public class Alumno implements java.io.Serializable{
   
    /* Datos Alumno */ 
   @XmlElement(name = "Dni")
   private String Dni;
   
   @XmlElement(name = "Nombre")
   private String Nombre;
   
   @XmlElement(name = "ApellidoPaterno")
   private String ApellidoPaterno;
   
   @XmlElement(name = "ApellidoMaterno")
   private String ApellidoMaterno;
   
   @XmlElement(name = "FechaNacimiento")
   private String FechaNacimiento;
   
   @XmlElement(name = "Sexo")
   private String Sexo;
   
   /* Datos de Utimo Año Escolar */ 
   
   @XmlElement(name = "Anio")
   private int Anio;
   
   @XmlElement(name = "Institucion")
   private String Institucion;
      
   @XmlElement(name = "Educacion")
   private String Educacion; 
   
   @XmlElement(name = "Grado")
   private String Grado;
   
   @XmlElement(name = "Estado")
   private String Estado;

   public Alumno(){       
   }
   
   public Alumno(String Dni,String ApellidoPaterno,String ApellidoMaterno,String Nombre,String FechaNacimiento,
           String Sexo,int Anio, String Institucion,String Educacion,String Grado,String Estado){  
       
       this.Dni = Dni;
       this.Nombre = Nombre;
       this.ApellidoPaterno = ApellidoPaterno;
       this.ApellidoMaterno = ApellidoMaterno;
       this.FechaNacimiento = FechaNacimiento;
       this.Sexo = Sexo;
       
       this.Anio = Anio;
       this.Institucion = Institucion;
       this.Educacion = Educacion;
       this.Grado = Grado;
       this.Estado = Estado;
   }
    
   
    /**
     * @return the Dni
     */
    public String getDni() {
        return Dni;
    }

    /**
     * @param Dni the Dni to set
     */
    public void setDni(String Dni) {
        this.Dni = Dni;
    }

    /**
     * @return the Nombre
     */
    public String getNombre() {
        return Nombre;
    }

    /**
     * @param Nombre the Nombre to set
     */
    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    /**
     * @return the ApellidoPaterno
     */
    public String getApellidoPaterno() {
        return ApellidoPaterno;
    }

    /**
     * @param ApellidoPaterno the ApellidoPaterno to set
     */
    public void setApellidoPaterno(String ApellidoPaterno) {
        this.ApellidoPaterno = ApellidoPaterno;
    }

    /**
     * @return the ApellidoMaterno
     */
    public String getApellidoMaterno() {
        return ApellidoMaterno;
    }

    /**
     * @param ApellidoMaterno the ApellidoMaterno to set
     */
    public void setApellidoMaterno(String ApellidoMaterno) {
        this.ApellidoMaterno = ApellidoMaterno;
    }

    /**
     * @return the AnioNacimiento
     */
    public String getFechaNacimiento() {
        return FechaNacimiento;
    }

    /**
     * @param AnioNacimiento the AnioNacimiento to set
     */
    public void setFechaNacimiento(String FechaNacimiento) {
        this.FechaNacimiento = FechaNacimiento;
    }

    /**
     * @return the Sexo
     */
    public String getSexo() {
        return Sexo;
    }

    /**
     * @param Sexo the Sexo to set
     */
    public void setSexo(String Sexo) {
        this.Sexo = Sexo;
    }

    /**
     * @return the Anio
     */
    public int getAnio() {
        return Anio;
    }

    /**
     * @param Anio the Anio to set
     */
    public void setAnio(int Anio) {
        this.Anio = Anio;
    }

    /**
     * @return the Institucion
     */
    public String getInstitucion() {
        return Institucion;
    }

    /**
     * @param Institucion the Institucion to set
     */
    public void setInstitucion(String Institucion) {
        this.Institucion = Institucion;
    }

    /**
     * @return the Educacion
     */
    public String getEducacion() {
        return Educacion;
    }

    /**
     * @param Educacion the Educacion to set
     */
    public void setEducacion(String Educacion) {
        this.Educacion = Educacion;
    }

    /**
     * @return the Grado
     */
    public String getGrado() {
        return Grado;
    }

    /**
     * @param Grado the Grado to set
     */
    public void setGrado(String Grado) {
        this.Grado = Grado;
    }

    /**
     * @return the Estado
     */
    public String getEstado() {
        return Estado;
    }

    /**
     * @param Estado the Estado to set
     */
    public void setEstado(String Estado) {
        this.Estado = Estado;
    }
   

   
}
