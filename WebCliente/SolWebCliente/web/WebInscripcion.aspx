﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebInscripcion.aspx.cs" Inherits="WebInscripcion" %>

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
                        <h5><asp:Label ID="lblInscripcion" runat="server" Text="Inscripcion"></asp:Label></h5>
                            <div class="buttons">                        
                                <asp:HyperLink ID="lnkAgregar" runat="server" 
                                    NavigateUrl="~/WebInscripcionAgregar.aspx" CssClass="btn btn-primary">
                                    <i class="icon-plus icon-white"></i>&nbsp;<asp:Label ID="lblCrearPerfil" runat="server" Text="Agregar Inscripcion"></asp:Label>
                                </asp:HyperLink>                     
                            </div>
                   </div>

                   <div class="widget-content">
                      <div style="padding-top:10px;padding-left:10px;padding-bottom:10px">
                        <asp:Panel runat="server" ID="pnlActivo">
                            <asp:Panel ID="pnlOk" runat="server" Visible="false">
                                <div class="alert alert-error">
                                    <button type="button" class="close" data-dismiss="alert">×</button>
                                    <strong>Ok!</strong>&nbsp;
                                    <asp:Literal ID="litOk" runat="server"></asp:Literal> 
                                </div>
                            </asp:Panel>
                            
                            <asp:Panel ID="pnlError" runat="server" Visible="false">
                                <div class="alert alert-error">
                                    <button type="button" class="close" data-dismiss="alert">×</button>
                                    <strong>Error!</strong>&nbsp;
                                    <asp:Literal ID="litError" runat="server"></asp:Literal> 
                                </div>
                            </asp:Panel>

                       

                            <telerik:RadGrid ID="gvwPerfiles" runat="server" CellSpacing="0" Culture="es-ES" 
                                    GridLines="None"   Width="800px"
                                    PageSize="15"  AllowFilteringByColumn="True" 
                                    AllowPaging="True" AllowSorting="True" 
                                    DataSourceID="SqlLinqPerfiles" onitemcommand="gvwPerfiles_ItemCommand" >

                                    <ClientSettings EnableRowHoverStyle="true" ></ClientSettings>
                                    <GroupingSettings CaseSensitive="false"/>
                                    <MasterTableView AutoGenerateColumns="False" DataKeyNames="CodigoInscripcion" 
                                        DataSourceID="SqlLinqPerfiles">
                                        <CommandItemSettings ExportToPdfText="Export to PDF" />
                                        <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" 
                                            Visible="True">
                                            <HeaderStyle Width="20px" />
                                        </RowIndicatorColumn>
                                        <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                                            Visible="True">
                                            <HeaderStyle Width="20px" />
                                        </ExpandCollapseColumn>

                                        <Columns>
                                            <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                                            UniqueName="temPerfil" HeaderText="" HeaderStyle-Width="50px"                                    
                                            HeaderButtonType="None" Reorderable="False" AllowFiltering="False">
                                                <ItemTemplate>
                                                   <asp:HyperLink ID="lnkEditar" runat="server" 
                                                    NavigateUrl='<%# "~/WebInscripcionAgregar.aspx?nCode="+Eval("CodigoInscripcion") %>' ToolTip="Edit" ><i class="icon-edit"></i></asp:HyperLink>
                                    
                                                    <asp:LinkButton ID="lnkEliminar" runat="server" meta:resourcekey="lnkEliminar" 
                                                            CommandName="Eliminar" ToolTip=""
                                                            CommandArgument='<%# Bind("CodigoInscripcion") %>'  OnClientClick="return confirm('Seguro que desea eliminar este Perfil?');">
                                                            <i class="icon-remove"></i>
                                                    </asp:LinkButton>                                    
                                                    <asp:Label ID="lblCodigo" runat="server" Text='<%# Bind("CodigoInscripcion") %>' Visible="False"></asp:Label>                                    
                               
                                               </ItemTemplate>
                                            </telerik:GridTemplateColumn> 
                                            
                                            <telerik:GridBoundColumn DataField="DNI" 
                                                HeaderStyle-Width="100px"   
                                                FilterControlAltText="Filter DNI column" HeaderText="DNI" 
                                                SortExpression="DNI" UniqueName="DNI">
                                            </telerik:GridBoundColumn>

                                            <telerik:GridBoundColumn DataField="Apoderado" 
                                                HeaderStyle-Width="400px"   
                                                FilterControlAltText="Filter Apoderado column" HeaderText="Apoderado" 
                                                SortExpression="Apoderado" UniqueName="Apoderado">
                                            </telerik:GridBoundColumn>

                                            <telerik:GridBoundColumn DataField="FechaInscripcion" DataType="System.DateTime" 
                                                HeaderStyle-Width="100px"   
                                                FilterControlAltText="Filter Fecha Inscripcion column" HeaderText="F. Inscrip"
                                                ReadOnly="True" SortExpression="FechaInscripcion" UniqueName="FechaInscripcion">
                                            </telerik:GridBoundColumn>
                                         
                                        </Columns>
                                        <EditFormSettings>
                                            <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                            </EditColumn>
                                        </EditFormSettings>
                                        <PagerStyle PageSizeControlType="RadComboBox" />
                                    </MasterTableView>
                                    <PagerStyle PageSizeControlType="RadComboBox" />
                                    <FilterMenu EnableImageSprites="False">
                                    </FilterMenu>
                            </telerik:RadGrid>
                          
                            <telerik:OpenAccessLinqDataSource ID="SqlLinqPerfiles" runat="server" 
                                ContextTypeName="it.dominio.DBContext" EntityTypeName="" 
                                onselecting="SqlLinqPerfiles_Selecting" ResourceSetName="Perfils">
                            </telerik:OpenAccessLinqDataSource>
                       
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
         <usrpagina:PiePagina ID="usrPie" runat="server" />
    </div>



    </form>
</body>
</html>
