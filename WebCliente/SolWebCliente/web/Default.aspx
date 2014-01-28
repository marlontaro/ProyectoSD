<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Src="~/Control/WebMenu.ascx" TagName="Menu" TagPrefix="usrpagina" %>
<%@ Register Src="~/Control/WebCabecera.ascx" TagName="Cabecera" TagPrefix="usrpagina" %>
<%@ Register Src="~/Control/WebPie.ascx" TagName="PiePagina" TagPrefix="usrpagina" %>
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
         

           <div class="row-fluid">
       
            <div class="span12">
                <div class="widget-box">
                    <div class="widget-title">
		                <h5><asp:Label ID="lblDashboard" runat="server" Text="Dashboard"></asp:Label></h5>                       
                    </div>
                    <div class="widget-content">
                        
                        <div  class="form-horizontal">            

                            <div class="control-group">
                                <asp:Label ID="lblMParticipante" runat="server" Text="Usuario" CssClass="control-label"  
                                    ></asp:Label>
                                <div class="controls">
                                       <span class="input-xlarge uneditable-input"><asp:Label ID="lblParticipante" runat="server" Text="Participante">
                                            </asp:Label>
                                       </span>                
                                </div>                        
                            </div>

                             <div class="control-group">
                                <asp:Label ID="lblMCorreo" runat="server" Text="Correo" CssClass="control-label" meta:resourcekey="lblMCorreo" 
                                    ></asp:Label>
                                <div class="controls">
                                       <span class="input-xlarge uneditable-input">
                                            <asp:Label ID="lblCorreo" runat="server" Text="Correo" >
                                            </asp:Label>
                                        </span>                
                                </div>                        
                            </div> 
                        </div>     
                    </div>
                </div>
            </div>
           </div>

           
            <asp:Panel ID="pnlCMS" runat="server">      
                <div class="row-fluid">
                    <div class="span12">
              
                        <div class="widget-box">
                            <div class="widget-title">
                                <h5><asp:Label ID="lblPendientes" runat="server" Text="CMS"></asp:Label></h5>
                            </div>
                            <div class="widget-content" style="height: 250px;">
                                <div class="span6" style="padding-top:10px;">
                                    <ul class="site-stats">
                                        <li>                        
                                            <asp:HyperLink ID="lnkPPagina" runat="server" NavigateUrl="~/CMS/WebPagina.aspx">
                                                <i class="icon-tag"></i><span style="width: 50px;"><strong style="color: #000000">
                                                    <asp:Label ID="lblCPagina" runat="server" Text="0"></asp:Label></strong></span>&nbsp;<small>
                                                    <asp:Label ID="lblPagina" runat="server" Text="Paginas" ></asp:Label></small>
                                            </asp:HyperLink>                                    
                                        </li>   
                                                          
                                        <li>
                                            <asp:HyperLink ID="lnkPPlantilla" runat="server" NavigateUrl="~/CMS/WebPlantilla.aspx">                                    
                                                <i class="icon-tag"></i><span style="width: 50px;"><strong style="color: #000000">
                                                    <asp:Label ID="lblCPlantilla" runat="server" Text="0"></asp:Label></strong></span>&nbsp;<small>
                                                    <asp:Label ID="lblPlantilla" runat="server" Text="Plantillas" ></asp:Label></small>                                    
                                            </asp:HyperLink>
                                        </li> 

                                        <li>
                                            <asp:HyperLink ID="lnkPSeccion" runat="server" NavigateUrl="~/CMS/WebSeccion.aspx">                                    
                                                <i class="icon-tag"></i><span style="width: 50px;"><strong style="color: #000000">
                                                    <asp:Label ID="lblCSeccion" runat="server" Text="0"></asp:Label></strong></span>&nbsp;<small>
                                                    <asp:Label ID="lblSeccion" runat="server" Text="Secciones" ></asp:Label></small>                                    
                                            </asp:HyperLink>
                                        </li> 

                                        <li>
                                            <asp:HyperLink ID="lnkPItem" runat="server" NavigateUrl="~/CMS/WebItem.aspx">                                    
                                                <i class="icon-tag"></i><span style="width: 50px;"><strong style="color: #000000">
                                                    <asp:Label ID="lblCItem" runat="server" Text="0"></asp:Label></strong></span>&nbsp;<small>
                                                    <asp:Label ID="lblItem" runat="server" Text="Items" ></asp:Label></small>                                    
                                            </asp:HyperLink>
                                        </li> 
                                    </ul>                        
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
