<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateInsert.aspx.cs" Inherits="ProjeEtkinlik.Views.User.UpdateInsert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" method="post">
        <div class="contact-wrap">
            <div class="row">
                <div class="col-lg-6  mb-5 mb-sm-2">
                    <h1>Profilim</h1>

                    <div class="row">
                        <div class="col-sm-12">
                            <div class="form-group">
                                <input
                                    type="text"
                                    class="form-control"
                                    id="txt_adsoyad"
                                    runat="server"
                                    aria-describedby="Telefon"
                                    placeholder="Ad Soyad" />
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-sm-12">
                            <div class="form-group">
                                <input
                                    type="text"
                                    class="form-control"
                                    id="txt_telefon"
                                    runat="server"
                                    aria-describedby="Telefon"
                                    placeholder="Telefon" />
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-sm-12">
                            <div class="form-group">
                                <input
                                    type="text"
                                    class="form-control"
                                    id="txt_email"
                                    runat="server"
                                    aria-describedby="email"
                                    placeholder="E-Mail" />
                            </div>
                        </div>
                    </div>


                    <div class="row">
                        <div class="col-sm-12">
                            <div class="form-group">
                                <input
                                    type="text"
                                    class="form-control"
                                    id="txt_sifre"
                                    runat="server"
                                    aria-describedby="sifre"
                                    placeholder="Şifre" />
                            </div>
                        </div>
                    </div>



                    <div class="row">
                        <div class="col-sm-12">
                            <div class="form-group">

                                <asp:Button ID="duzenle" class="btn btn-lg btn-dark font-weight-bold" runat="server" Text="Düzenle" OnClick="duzenle_Click" />
                                <asp:Button ID="sil" class="btn btn-lg btn-light font-weight-bold" runat="server" Text="Sil" OnClick="sil_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
