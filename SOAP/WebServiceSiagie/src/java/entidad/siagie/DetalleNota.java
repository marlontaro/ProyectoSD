package entidad.siagie;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


@XmlType(name = "DetalleNota")
public class DetalleNota implements java.io.Serializable{
    
   @XmlElement(name = "Dni")
   private String Dni;
   
   @XmlElement(name = "Curso")
   private String Curso;
   
   @XmlElement(name = "Estado")
   private String Estado;
   
   @XmlElement(name = "Nota")
   private double Nota;

   public DetalleNota(){}
   
   public DetalleNota(String Dni,String Curso,String Estado,double Nota){
       this.Dni = Dni;
       this.Curso = Curso;
       this.Estado = Estado;
       this.Nota = Nota;
   }
   
   
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
     * @return the Curso
     */
    public String getCurso() {
        return Curso;
    }

    /**
     * @param Curso the Curso to set
     */
    public void setCurso(String Curso) {
        this.Curso = Curso;
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

    /**
     * @return the nota
     */
    public double getNota() {
        return Nota;
    }

    /**
     * @param nota the nota to set
     */
    public void setNota(double nota) {
        this.Nota = nota;
    }
}
