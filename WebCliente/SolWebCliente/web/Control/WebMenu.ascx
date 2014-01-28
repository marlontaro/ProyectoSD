﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebMenu.ascx.cs" Inherits="Control_WebMenu" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %> 

<telerik:RadScriptManager ID="ScriptManager1" runat="server" ></telerik:RadScriptManager>

<script type="text/javascript">
    function itemOpened(s, e) {
        if ($telerik.isIE8) {
            // Fix an IE 8 bug that causes the list bullets to disappear (standards mode only)
            $telerik.$("li", e.get_item().get_element())
            .each(function () { this.style.cssText = this.style.cssText; });
        }
    }
</script>

<div class="navbar navbar-fixed-top" >
<div class="navbar-inner">    
    
    <asp:HyperLink ID="lnkMarca" runat="server" NavigateUrl="~/CMS/Default.aspx" CssClass="brand">
        &nbsp;<asp:Label ID="lblMarca" runat="server" Text="CMS Administrador"></asp:Label>
    </asp:HyperLink>
         
    <telerik:RadMenu runat="server" ID="radInicio" Skin="Sitefinity" OnClientItemOpened="itemOpened"
        Width="100px" Height="40px" EnableShadows="true" Visible="false">
        <Items>
            <telerik:RadMenuItem Text="Inicio">
                <ItemTemplate>
                    <div style="height:35px;padding-top:7px;line-height:25px;" class="demolink">
                            <asp:HyperLink ID="lnkInicio" runat="server" NavigateUrl="~/CMS/Default.aspx">
                            <i class="icon-home"></i>&nbsp;&nbsp;<asp:Label ID="lblInicio" runat="server" Text="Inicio" Font-Size="16px"></asp:Label>
                            </asp:HyperLink>
                    </div>
                </ItemTemplate>                        
            </telerik:RadMenuItem>
        </Items>
    </telerik:RadMenu>

        <telerik:RadMenu runat="server" ID="radCMS" Skin="Sitefinity" OnClientItemOpened="itemOpened"
            Width="80px" Height="40px" EnableShadows="true" Visible="false">
            <Items>
               <telerik:RadMenuItem Text="Tabla">
                    <ItemTemplate>
                        <div style="height:35px;padding-top:7px;line-height:25px;" class="demolink">
                          <a href="#">
                                <asp:Label ID="lblTabla" runat="server" Text="CMS" Font-Size="16px"></asp:Label>
                            </a>
                        </div>
                    </ItemTemplate>  
                    <Items>
                        <telerik:RadMenuItem Width="200px" Text="TablaA">
                            <ItemTemplate>                               

                                   <asp:Panel ID="pnlUsuario" runat="server">   
                                      <div style="height:30px;" class="demolink"> 
                                            <asp:HyperLink ID="lnkUsuario" runat="server" NavigateUrl="~/CMS/WebPagina.aspx">
                                                <asp:Label ID="lblUsuario" runat="server" Text="Pagina" Font-Size="16px"></asp:Label>
                                            </asp:HyperLink> 
                                      </div>
                                   </asp:Panel> 

                                   <asp:Panel ID="pnlPerfil" runat="server">   
                                      <div style="height:30px;" class="demolink"> 
                                             <asp:HyperLink ID="lnkPerfil" runat="server" NavigateUrl="~/CMS/WebPlantilla.aspx">
                                                <asp:Label ID="lblPerfil" runat="server" Text="Plantilla" Font-Size="16px"></asp:Label>
                                             </asp:HyperLink>
                                      </div>
                                   </asp:Panel> 

                                      <asp:Panel ID="Panel1" runat="server">   
                                      <div style="height:30px;" class="demolink"> 
                                             <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CMS/WebSeccion.aspx">
                                                <asp:Label ID="Label1" runat="server" Text="Seccion" Font-Size="16px"></asp:Label>
                                             </asp:HyperLink>
                                      </div>
                                   </asp:Panel> 

                            </ItemTemplate>
                        </telerik:RadMenuItem>
                    </Items>                    
               </telerik:RadMenuItem>
            </Items>
        </telerik:RadMenu>

       <telerik:RadMenu runat="server" ID="radBuscador" Skin="Sitefinity" OnClientItemOpened="itemOpened"
            Width="100px" Height="40px" EnableShadows="true" Visible="false">
            <Items>
               <telerik:RadMenuItem Text="Buscador" Owner="radBuscador">
                    <ItemTemplate>
                        <div style="height:35px;padding-top:7px;line-height:25px;" class="demolink">
                            <a href="#">
                                <asp:Label ID="lblTabla" runat="server" Text="Buscador" Font-Size="16px"></asp:Label>
                            </a>
                        </div>
                    </ItemTemplate>                
                    
                    <Items>
                        <telerik:RadMenuItem Width="200px" Text="TablaA">
                            <ItemTemplate>                               

                                   <asp:Panel ID="pnlListado" runat="server">   
                                      <div style="height:30px;" class="demolink"> 
                                            <asp:HyperLink ID="lnkListado" runat="server" NavigateUrl="~/CMS/WebItem.aspx">
                                                <asp:Label ID="lblListado" runat="server" Text="Listado" Font-Size="16px"></asp:Label>
                                            </asp:HyperLink> 
                                      </div>
                                   </asp:Panel> 
                                  

                            </ItemTemplate>
                        </telerik:RadMenuItem>

                        <telerik:RadMenuItem Width="200px" Text="Item">
                            <ItemTemplate>                               

                                   <asp:Panel ID="pnlListado" runat="server">   
                                      <div style="height:30px;" class="demolink"> 
                                            <a href="#">
                                                <asp:Label ID="lblItem" runat="server" Text="Items" Font-Size="16px"></asp:Label>
                                                <i class="icon-chevron-right"></i>
                                            </a>
                                      </div>
                                   </asp:Panel> 
                                  

                            </ItemTemplate>
                        </telerik:RadMenuItem>
                    </Items>                            
               </telerik:RadMenuItem>
            </Items>

       </telerik:RadMenu>

        <telerik:RadMenu runat="server" ID="radSeguridad" Skin="Sitefinity" OnClientItemOpened="itemOpened"
            Width="100px" Height="40px" EnableShadows="true" Visible="false">
            <Items>
               <telerik:RadMenuItem Text="Tabla">
                    <ItemTemplate>
                        <div style="height:35px;padding-top:7px;line-height:25px;" class="demolink">
                          <a href="#">
                                <asp:Label ID="lblTabla" runat="server" Text="Seguridad" Font-Size="16px"></asp:Label>
                            </a>
                        </div>
                    </ItemTemplate>  
                    <Items>
                        <telerik:RadMenuItem Width="200px" Text="TablaA">
                            <ItemTemplate>
                               

                                   <asp:Panel ID="pnlUsuario" runat="server">   
                                      <div style="height:30px;" class="demolink"> 
                                            <asp:HyperLink ID="lnkUsuario" runat="server" NavigateUrl="~/CMS/WebUsuario.aspx">
                                                <asp:Label ID="lblUsuario" runat="server" Text="Usuario" Font-Size="16px"></asp:Label>
                                            </asp:HyperLink> 
                                      </div>
                                   </asp:Panel> 

                                   <asp:Panel ID="pnlPerfil" runat="server">   
                                      <div style="height:30px;" class="demolink"> 
                                             <asp:HyperLink ID="lnkPerfil" runat="server" NavigateUrl="~/CMS/WebPerfil.aspx">
                                                <asp:Label ID="lblPerfil" runat="server" Text="Perfil" Font-Size="16px"></asp:Label>
                                             </asp:HyperLink>
                                      </div>
                                   </asp:Panel> 

                            </ItemTemplate>
                        </telerik:RadMenuItem>
                    </Items>                    
               </telerik:RadMenuItem>
            </Items>
        </telerik:RadMenu>
  

    <telerik:RadMenu runat="server" ID="radWeb" Skin="Sitefinity" OnClientItemOpened="itemOpened"
        Width="150px" Height="40px" EnableShadows="true" Visible="true">
        <Items>
            <telerik:RadMenuItem Text="Web">
                <ItemTemplate>
                    <div style="height:35px;padding-top:7px;line-height:25px;" class="demolink">
                        <asp:HyperLink ID="lnkWeb" runat="server" NavigateUrl="~/">
                        <i class="icon-globe"></i>&nbsp;&nbsp;<asp:Label ID="lblWeb" runat="server" Text="Ir a Web" Font-Size="16px"></asp:Label>
                        </asp:HyperLink>
                    </div>
                </ItemTemplate>                        
            </telerik:RadMenuItem>
        </Items>
    </telerik:RadMenu>

        <div class="nav pull-right">

          <telerik:RadMenu runat="server" ID="radUsuario" Skin="Sitefinity" OnClientItemOpened="itemOpened"
                Width="100%" Height="40px" EnableShadows="true" Visible="false">
                <Items>
                   <telerik:RadMenuItem Text="Usuario"  CssClass="rightMenu" >
                        <ItemTemplate >
                            <div style="height:35px;padding-top:7px;line-height:25px;text-align:right" class="demolink">                            
                               <a href="#">
                                    <i class="icon-user"></i>&nbsp;
                                    <asp:Label ID="lblInfo" runat="server" Text="Usuario"  Font-Size="16px"></asp:Label> 
                               </a>
                            </div>
                        </ItemTemplate>  
                        <GroupSettings ExpandDirection="Down" />
                        <Items>
                            <telerik:RadMenuItem Width="150px" Text="UsuarioA">
                                <ItemTemplate>
                                
                                    <div style="height:30px;" class="demolink">                              
                                        <asp:HyperLink ID="lnkVista" runat="server" CssClass="white" NavigateUrl="~/CMS/WebMiPerfil.aspx"> 
                                            <asp:Label ID="lblVista" runat="server" Text="Mi Perfil" Font-Size="16px"></asp:Label>
                                        </asp:HyperLink>  
                                    </div>
                                   
                                    <div style="height:30px;" class="demolink">     
                                        <asp:HyperLink ID="lnkCerrar" runat="server" CssClass="white" NavigateUrl="~/CMS/Default.aspx?cCerrar=1">
                                            <asp:Label ID="lblCerrar" runat="server" Text="Cerrar" Font-Size="16px"></asp:Label>
                                        </asp:HyperLink>
                                    </div>

                                </ItemTemplate>
                            </telerik:RadMenuItem>
                        </Items>                    
                   </telerik:RadMenuItem>
                </Items>
            </telerik:RadMenu>
        
        </div>
     

</div>
</div> 

