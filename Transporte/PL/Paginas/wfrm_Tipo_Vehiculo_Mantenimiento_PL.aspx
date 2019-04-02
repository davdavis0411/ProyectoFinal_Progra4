﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/msr_Navegacion_PL.Master" AutoEventWireup="true" CodeBehind="wfrm_Tipo_Vehiculo_Mantenimiento_PL.aspx.cs" Inherits="PL.Paginas.wfrm_Tipo_Vehiculo_Mantenimiento_PL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="forms">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-heading">

                        <div>
                            <button type="submit" id="btn_Guardar" class="button" style='background: url(../Recursos/Save.png);'></button>
                            <button type="reset" id="btn_Limpiar" class="button" style='background: url(../Recursos/Refresh.png);'></button>
                            <button type="submit" id="btn_Atras" class="button" onclick="location.href='wfrm_Tipo_Vehiculo_Catalogo_PL.aspx';" style='background: url(../Recursos/Exit.png);'></button>
                        </div>
                    </div>
                    <form id="Vehiculo_Catalogo" method="post">
                        <div class="row">
                            <div class="col-md-6">

                                    <div>
                                    <label for="txt_Id_Tipo_Vehiculo">ID Tipo de Vehículo: </label><input name="id_tipo_vehiculo" type="text" class="form-control" id="txt_Id_Tipo_Vehiculo" placeholder="Ingrese el ID..." required=""/>
                                    </div>

                                    <div>
                                    <label for="txt_Decripcion_Tipo_Vehiculo">Descripcion del Tipo de Vehículo: </label><input name="Descripcion_Tipo_Vehiculo" type="text" class="form-control" id="txt_Decripcion_Tipo_Vehiculo" placeholder="Ingrese la Descipción..." required=""/>
                                    </div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </section>

</asp:Content>
