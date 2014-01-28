<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebLogin.aspx.cs" Inherits="WebLogin" %>
<%@ Register Src="~/Control/WebMenu.ascx" TagName="Menu" TagPrefix="usrpagina" %>
<%@ Register Src="~/Control/WebCabecera.ascx" TagName="Cabecera" TagPrefix="usrpagina" %>
<%@ Register Src="~/Control/WebPie.ascx" TagName="PiePagina" TagPrefix="usrpagina" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <!--Cabecera-->
   <usrpagina:Cabecera ID="usrCabecera" runat="server" />
   <!--Cabecera-->
</head>
<body>
    <form id="form1" runat="server">
        <!--Menu-->
        <usrpagina:Menu ID="usrMenu" runat="server" />
        <!--Menu-->

        <div class="container-fluid" style="min-width:940px">
          <asp:Panel ID="pnlform" runat="server">   
          <div class="row-fluid">       
                <div class="span12"> 
                
                <asp:Panel ID="pnlError" runat="server" Visible="false">
                    <div class="alert alert-error">
                        <button type="button" class="close" data-dismiss="alert">×</button> 
                        <strong>Oh Error!</strong>
                        <asp:Literal ID="litError" runat="server"></asp:Literal>
                    </div>        
                </asp:Panel>    
                
                <asp:ValidationSummary ID="valsum1" HeaderText="<strong>Oh Error!</strong>" runat="server"
                          ValidationGroup="SubmitInfo"
                          EnableClientScript="False" CssClass="alert alert-error" 
                />
                </div>
                </div>

                <div class="row-fluid">       
                     <div class="span5 offset3"> 
                        <div style="width: 520px; padding-top:30px;padding-bottom:30px;">   
                        <div class="widget-box">
                        <div class="widget-title">
		                    <span class="icon">
                                <div style="padding: 10px">
                                <i class="icon-user"></i>
                                </div>
                            </span>
                            <h5>
                             <asp:Label ID="lblLogin" runat="server" Text="Inicie Sesión"  meta:resourcekey="lblLogin"></asp:Label>  
                            </h5>
                        </div>

                        <div class="widget-content">  
                        
                      
                            <div class="form-horizontal" style="padding-top:10px;">

                       
                            <div class="control-group">
                                <label class="control-label">
                                    <asp:Label ID="lblUsuario" runat="server" Text="Usuario" AssociatedControlID="txtUsuario" meta:resourcekey="lblUsuario"></asp:Label>  
                                </label>
                                <div class="controls">
                                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                                         
                                </div>
                            </div>

                            <div class="control-group">
                                <label class="control-label">
                                    <asp:Label ID="lblContra" runat="server" Text="Contraseñia" AssociatedControlID="txtContra" meta:resourcekey="lblContra"></asp:Label>  
                                </label>
                                <div class="controls">
                                    <asp:TextBox ID="txtContra" runat="server" TextMode="Password"></asp:TextBox>
                     
                                </div>
                            </div>

                                <div class="control-group">
                                    <label class="control-label">
                                      </label>
                                    <div class="controls">
                                        <div style="float:right;padding-right:30px;">                                           
                                            <asp:HyperLink ID="lnkRecuperar" runat="server" NavigateUrl="~/CMS/WebRecuperar.aspx">
                                                <asp:Label ID="lblRecuperar" runat="server" Text="Recuperar"></asp:Label> 
                                            </asp:HyperLink>
                                        </div>
                                        <div style="clear:both"></div>
                                    </div>
                                </div>
                    
                            <div class="form-actions">
                                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" 
                                    CssClass="btn btn-primary" meta:resourcekey="btnIngresar" 
                                    onclick="btnIngresar_Click" />
                            </div>
                            </div>
                        
                            <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="Default">
                        
                            </telerik:RadAjaxLoadingPanel>
                     
                        </div>
                        </div>
                        </div>
                      </div>
                </div>
          </asp:Panel>
            <!--Pie-->
            <usrpagina:PiePagina ID="usrPie" runat="server" />
            <!---Pie-->
        </div>
    </form>
</body>
</html>
