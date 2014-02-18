<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebMatriculaAgregar.aspx.cs" Inherits="WebMatriculaAgregar" %>

<%@ Register Assembly="Telerik.OpenAccess.Web.40" Namespace="Telerik.OpenAccess.Web"
    TagPrefix="telerik" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="~/Control/WebMenu.ascx" TagName="Menu" TagPrefix="usrpagina" %>
<%@ Register Src="~/Control/WebCabecera.ascx" TagName="Cabecera" TagPrefix="usrpagina" %>
<%@ Register Src="~/Control/WebPie.ascx" TagName="PiePagina" TagPrefix="usrpagina" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <!--Cabecera-->
   <usrpagina:Cabecera ID="usrCabecera" runat="server" />
   <!--Cabecera-->
    <style type="text/css">
        
        input, textarea, .uneditable-input {
            width: auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <!--Menu-->
    <usrpagina:Menu ID="usrMenu" runat="server" />
    <!--Menu-->

     <div class="container-fluid" style="min-width:940px">
        <div class="row-fluid">
            <div class="span12">
                <div class="widget-box">
                    <div class="widget-title">
                        <h5>
                            <asp:Label ID="lblInscripcionAgregar" runat="server" Text="Agregar Matricula" ></asp:Label>                         
                        </h5> 
                    </div>
                    <div class="widget-content">
                         <asp:Panel ID="pnlActivo" runat="server">
                            <div style="padding-top:10px">
                                <asp:Label ID="lblCodigo" runat="server" Text="0" Visible="false"></asp:Label> 
                    
                                <asp:Panel ID="pnlOk" runat="server" Visible="false">
                                    <div class="alert alert-success">
                                        <button type="button" class="close" data-dismiss="alert">×</button> 
                                        <strong>Ok!</strong>&nbsp;<asp:Literal ID="litOk" runat="server"></asp:Literal>                        
                                    </div>
                                </asp:Panel>

                                <asp:Panel ID="pnlError" runat="server" Visible="false">
                                    <div class="alert alert-error">
                                        <button type="button" class="close" data-dismiss="alert">×</button> 
                                            <strong>Oh Error!</strong>
                                            <asp:Literal ID="litError" runat="server"></asp:Literal>
                                    </div>        
                                </asp:Panel>  
                                
                                 <div class="form-horizontal">
                                    
                                    <div>
                                        <div style="float:left;width:370px">
                                             <div class="control-group">                                        
                                                <span class="control-label">
                                                    <asp:Label ID="lblDNI" runat="server" Text="DNI" CssClass="pull-right" 
                                                        AssociatedControlID="txtDni"></asp:Label>
                                                    <span class="pull-right requerido">*</span>
                                                </span>
                                                <div class="controls">
                                                    <asp:TextBox ID="txtDNI" runat="server" Width="120px"></asp:TextBox>
                                                </div>                        
                                            </div>
                                        </div>
                                         
                                        <div style="clear:both">
                                        </div>
                                    </div>
                                    <div class="control-group">                                        
                                        <span class="control-label">
                                            <asp:Label ID="Label3" runat="server" Text="Tipo" CssClass="pull-right" 
                                                AssociatedControlID="cboTipo"></asp:Label>
                                            <span class="pull-right requerido">*</span>
                                        </span>
                                        <div class="controls">
                                            <asp:DropDownList ID="cboTipo" runat="server">
                                                <asp:ListItem Text="Seleccione" Value="0"></asp:ListItem>
                                                <asp:ListItem Text="Madre" Value="1"></asp:ListItem>
                                                <asp:ListItem Text="Padre" Value="2"></asp:ListItem>
                                                <asp:ListItem Text="Apoderado" Value="3"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>                        
                                    </div>
                                    
                                    <div>
                                        <div style="float:left;width:450px">

                                            <div class="control-group">
                                                <span class="control-label">
                                                    <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="pull-right" 
                                                        AssociatedControlID="txtNombre"></asp:Label>
                                                    <span class="pull-right requerido">*</span>
                                                </span>
                                                <div class="controls">
                                                    <asp:TextBox ID="txtNombre" runat="server" Width="300px"></asp:TextBox>
                                                </div>                        
                                            </div>

                                         </div>
                                         
                                         <div style="float:left">

                                             <div class="control-group">
                                                <span class="control-label">
                                                    <asp:Label ID="lblApellido" runat="server" Text="Apellidos" CssClass="pull-right" 
                                                       AssociatedControlID="txtApellido"></asp:Label>
                                                    <span class="pull-right requerido">*</span>
                                                </span>
                                                <div class="controls">
                                                    <asp:TextBox ID="txtApellido" runat="server"  Width="300px" ></asp:TextBox>
                                                </div>                        
                                            </div>
                                         
                                         </div>
                                         <div style="clear:both">
                                         </div>
                                    </div>

                                     <div class="control-group">                                        
                                        <span class="control-label">
                                            <asp:Label ID="lblDireccion" runat="server" Text="Direccion" CssClass="pull-right" 
                                                AssociatedControlID="txtDireccion"></asp:Label>
                                            <span class="pull-right requerido">*</span>
                                        </span>
                                        <div class="controls">
                                            <asp:TextBox ID="txtDireccion" runat="server" Width="750px"></asp:TextBox>
                                        </div>                        
                                    </div>

                                     
                                    <div>
                                        <div style="float:left;width:450px">
                                             <div class="control-group">                                        
                                                <span class="control-label">
                                                    <asp:Label ID="lblDepartamento" runat="server" Text="Departamento" CssClass="pull-right" 
                                                        AssociatedControlID="cboDepartamento"></asp:Label>
                                                    <span class="pull-right requerido">*</span>
                                                </span>
                                                <div class="controls">
                                                    <asp:DropDownList ID="cboDepartamento" runat="server" AutoPostBack="True" 
                                                        onselectedindexchanged="cboDepartamento_SelectedIndexChanged">
                                                       
                                                    </asp:DropDownList>
                                                </div>                        
                                            </div>
                                        </div>
                                         
                                         <div style="float:left">
                                             <div class="control-group">                                        
                                                <span class="control-label">
                                                    <asp:Label ID="lblProvincia" runat="server" Text="Provincia" CssClass="pull-right" 
                                                        AssociatedControlID="cboProvincia"></asp:Label>
                                                    <span class="pull-right requerido">*</span>
                                                </span>
                                                <div class="controls">
                                                    <asp:DropDownList ID="cboProvincia" runat="server" AutoPostBack="True" 
                                                        onselectedindexchanged="cboProvincia_SelectedIndexChanged">
                                                        <asp:ListItem Text="SELECCIONE" Value="0"></asp:ListItem> 
                                                    </asp:DropDownList>
                                                </div>                        
                                            </div>

                                         </div>
                                         <div style="clear:both">
                                         </div>
                                    </div>
                                
                                    <div>
                                        <div style="float:left;width:450px">
                                             <div class="control-group">                                        
                                                <span class="control-label">
                                                    <asp:Label ID="lblDistrito" runat="server" Text="Distrito" CssClass="pull-right" 
                                                        AssociatedControlID="cboDistrito"></asp:Label>
                                                    <span class="pull-right requerido">*</span>
                                                </span>
                                                <div class="controls">
                                                    <asp:DropDownList ID="cboDistrito" runat="server">
                                                        <asp:ListItem Text="SELECCIONE" Value="0"></asp:ListItem> 
                                                    </asp:DropDownList>
                                                </div>                        
                                            </div>
                                        </div>
                                    
                                        <div style="float:left;">
                                             <div class="control-group">                                        
                                                    <span class="control-label">
                                                        <asp:Label ID="lblTelefono" runat="server" Text="Telefono/Celular" CssClass="pull-right" 
                                                            AssociatedControlID="txtTelefono"></asp:Label> 
                                                    </span>
                                                    <div class="controls">
                                                          <asp:TextBox ID="txtTelefono" runat="server" Width="300px"></asp:TextBox>
                                                    </div>                        
                                                </div>
                                         </div>
                                         <div style="clear:both">
                                         </div>
                                    </div>

                                </div>
                                 
                                 <div>
                                    <div style="float:left;padding-right:20px;padding-left:30px">
                                        <h5>Hijo</h5>
                                    </div>                                        
                                    <div style="clear:both"></div>                      
                                </div>
                                <hr />

                                  <div class="form-horizontal" style="padding-top:5px">
                                    
                                    <div>
                                        <div style="float:left;width:370px">
                                                <div class="control-group">                                        
                                                <span class="control-label">
                                                    <asp:Label ID="lblHijoDni" runat="server" Text="DNI" CssClass="pull-right"   AssociatedControlID="txtHijoDni"                                                                              ></asp:Label>
                                                    <span class="pull-right requerido">*</span>
                                                </span>
                                                <div class="controls">
                                                    <asp:TextBox ID="txtHijoDni" runat="server" Width="120px" Text='<%# Bind("DNI") %>'></asp:TextBox>
                                                </div>                         
                                            </div>
                                        </div>
 

                                        <div style="clear:both">
                                        </div>
                                    </div>
                                    
                                      
                                    <div>
                                        <div style="float:left;width:450px">

                                            <div class="control-group">
                                                <span class="control-label">
                                                    <asp:Label ID="lblHijoNombre" runat="server" Text="Nombre" CssClass="pull-right" 
                                                        AssociatedControlID="txtHijoNombre"></asp:Label>
                                                    <span class="pull-right requerido">*</span>
                                                </span>
                                                <div class="controls">
                                                    <asp:TextBox ID="txtHijoNombre" runat="server" Width="300px" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                                                </div>                        
                                            </div>

                                            </div>
                                         
                                            <div style="float:left">

                                                <div class="control-group">
                                                <span class="control-label">
                                                    <asp:Label ID="lblHijoApellido" runat="server" Text="Apellidos" CssClass="pull-right" 
                                                        AssociatedControlID="txtHijoApellido"></asp:Label>
                                                    <span class="pull-right requerido">*</span>
                                                </span>
                                                <div class="controls">
                                                    <asp:TextBox ID="txtHijoApellido" runat="server"  Width="300px" Text='<%# Bind("ApellidoPaterno") %>'></asp:TextBox>
                                                </div>                        
                                            </div>
                                         
                                            </div>
                                            <div style="clear:both">
                                            </div>
                                    </div>


                                        <div>
                                        <div style="float:left;width:450px">

                                            <div class="control-group">
                                                <span class="control-label">
                                                    <asp:Label ID="Label5" runat="server" Text="Fecha de Nacimiento" CssClass="pull-right" 
                                                        ></asp:Label>
                                                    <span class="pull-right requerido">*</span>
                                                </span>
                                                <div class="controls">
                                                    <telerik:RadDatePicker ID="dtFecha" runat="server" Height="30px" SelectedDate='<%# Bind("FechaNacimiento") %>'>
                                                    </telerik:RadDatePicker>
                                                </div>                        
                                            </div>

                                            </div>
                                         
                                            <div style="float:left">

                                                <div class="control-group">
                                                <span class="control-label">
                                                    <asp:Label ID="Label6" runat="server" Text="Sexo" CssClass="pull-right" 
                                                        AssociatedControlID="rbHombre"></asp:Label>
                                                    <span class="pull-right requerido">*</span>
                                                </span>
                                                <div class="controls">
                                                    <label class="radio inline">
                                                        <asp:RadioButton ID="rbHombre" runat="server" GroupName="grSexo" /> Hombre
                                                    </label>

                                                    <label class="radio inline">
                                                    <asp:RadioButton ID="rbMujer" runat="server" GroupName="grSexo" />Mujer
                                                    </label>
                                                    
                                                    <label class="radio inline">
                                                    <asp:RadioButton ID="rbOtro" runat="server" GroupName="grSexo" />Otro
                                                    </label>
                                                </div>                        
                                            </div>
                                         
                                            </div>
                                            <div style="clear:both">
                                            </div>
                                    </div>


                                    <div>
                                        <div style="float:left;width:450px">

                                            <div class="control-group">
                                                <span class="control-label">
                                                    <asp:Label ID="Label7" runat="server" Text="Educacion" CssClass="pull-right" 
                                                        AssociatedControlID="cboEducacion" ></asp:Label>
                                                    <span class="pull-right requerido">*</span>
                                                </span>
                                                <div class="controls">
                                                        <asp:DropDownList ID="cboEducacion" runat="server" AutoPostBack="true"
                                                            onselectedindexchanged="cboEducacion_SelectedIndexChanged">
                                                        <asp:ListItem Text="Seleccione" Value="0"></asp:ListItem> 
                                                        <asp:ListItem Text="Inicial" Value="1"></asp:ListItem> 
                                                        <asp:ListItem Text="Primaria" Value="2"></asp:ListItem> 
                                                        <asp:ListItem Text="Secundaria" Value="3"></asp:ListItem> 
                                                    </asp:DropDownList>
                                                </div>                        
                                            </div>

                                            </div>
                                         
                                            <div style="float:left">

                                                <div class="control-group">
                                                <span class="control-label">
                                                    <asp:Label ID="Label8" runat="server" Text="Seccion" CssClass="pull-right" 
                                                        AssociatedControlID="cboSeccion"  ></asp:Label>
                                                    <span class="pull-right requerido">*</span>
                                                </span>
                                                <div class="controls">
                                                        <asp:DropDownList ID="cboSeccion" runat="server" >    
                                                        <asp:ListItem Text="Seleccione" Value="0"></asp:ListItem>                                                     
                                                    </asp:DropDownList>
                                                </div>                        
                                            </div>

                                            </div>
                                            <div style="clear:both">
                                            </div>
                                    </div> 
                                                             
                                </div>

                                   
                                 <div>
                                    <div style="float:left;padding-right:20px;padding-left:30px">
                                        <h5>Matricula</h5>
                                    </div>                                        
                                    <div style="clear:both"></div>                      
                                </div>
                                <hr />

                                 <div class="form-horizontal">
                                    <div class="form-actions">
                                       <asp:LinkButton ID="lnkGuardar" runat="server" CssClass="btn btn-primary" 
                                            onclick="lnkGuardar_Click">
                                                Guardar
                                        </asp:LinkButton>

                                        <asp:HyperLink ID="lnkVolver" runat="server" CssClass="btn"  NavigateUrl="~/WebInscripcion.aspx">Volver</asp:HyperLink>
                                    </div>
                                </div>
                            </div>
                         </asp:Panel>
                         <asp:Panel ID="pnlInactivo" runat="server" Visible="False">
                        <div class="bs-docs-example">
                            <div class="alert alert-error">
                            <button type="button" class="close" data-dismiss="alert">×</button> 
                            <strong>Oh Error!</strong>
                            <asp:Literal ID="litSinConexion" runat="server"></asp:Literal>                        
                            </div>
                        </div>        
                      </asp:Panel>
                    </div>
                </div>
            </div>
       </div>
    </div>
    </form>
</body>
</html>
