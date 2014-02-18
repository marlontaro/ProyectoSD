<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebAprobacionDireccionDetalle.aspx.cs" Inherits="WebAprobacionDireccionDetalle" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="~/Control/WebMenu.ascx" TagName="Menu" TagPrefix="usrpagina" %>
<%@ Register Src="~/Control/WebCabecera.ascx" TagName="Cabecera" TagPrefix="usrpagina" %>
<%@ Register Src="~/Control/WebPie.ascx" TagName="PiePagina" TagPrefix="usrpagina" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
                            <asp:Label ID="lblEvaluacion" runat="server" Text="Evaluacion" ></asp:Label> 
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
                                     
                                    <div class="control-group">                                        
                                        <span class="control-label">
                                            <asp:Label ID="lblDNI" runat="server" Text="DNI" CssClass="pull-right" 
                                                AssociatedControlID="txtDni"></asp:Label>
                                            <span class="pull-right requerido">*</span>
                                        </span>
                                        <div class="controls">
                                            <asp:TextBox ID="txtDNI" runat="server" Width="120px" Enabled="false"></asp:TextBox>
                                        </div>                        
                                    </div>

                                    <div class="control-group">                                        
                                        <span class="control-label">
                                            <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="pull-right" 
                                                AssociatedControlID="txtDni"></asp:Label>
                                            <span class="pull-right requerido">*</span>
                                        </span>
                                        <div class="controls">
                                            <asp:TextBox ID="txtNombre" runat="server" Width="500px" Enabled="false"></asp:TextBox>
                                        </div>                        
                                    </div>
                                        
                               </div>

                                <div>
                                    <div style="float:left;padding-right:20px;padding-left:30px">
                                        <h5>Respuesta</h5>
                                    </div> 
                                    <div style="clear:both"></div>                      
                                </div>
                                <hr />

                                <div class="form-horizontal">
                                    
                                    <div class="control-group">
                                        <span class="control-label">
                                            <asp:Label ID="lblRespuesta" runat="server" Text="Respuesta" CssClass="pull-right" 
                                                AssociatedControlID="rbAceptado"></asp:Label>
                                            <span class="pull-right requerido">*</span>
                                        </span>
                                        <div class="controls">
                                            <label class="radio inline">
                                                <asp:RadioButton ID="rbAceptado" runat="server" GroupName="grRespuesta" /> Aceptado
                                            </label>

                                            <label class="radio inline">
                                            <asp:RadioButton ID="rbNoAceptado" runat="server" GroupName="grRespuesta" />No Aceptado
                                            </label> 
                                           
                                        </div>                        
                                    </div>

                                    <div class="control-group">
                                        <span class="control-label">
                                            <asp:Label ID="Label1" runat="server" Text="Observacion" CssClass="pull-right" 
                                                ></asp:Label>
                                            <span class="pull-right requerido">*</span>
                                        </span>
                                        <div class="controls">
                                            <asp:TextBox ID="txtObservacion" runat="server" TextMode="MultiLine" Width="500px"></asp:TextBox>
                                           
                                        </div>                        
                                    </div>
                                </div>

                                  <div class="form-horizontal">
                                    <div class="form-actions">
                                       <asp:LinkButton ID="lnkGuardar" runat="server" CssClass="btn btn-primary" 
                                            onclick="lnkGuardar_Click">
                                                Guardar
                                        </asp:LinkButton>

                                        <asp:HyperLink ID="lnkVolver" runat="server" CssClass="btn"  NavigateUrl="~/WebAprobacionAcademica.aspx">Volver</asp:HyperLink>
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
