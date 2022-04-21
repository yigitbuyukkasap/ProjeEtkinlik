<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="LoginSignUp.aspx.cs" Inherits="ProjeEtkinlik.Views.LoginSignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form method="post" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div class="text-center">
                        <h1 class="text-center mt-5">Giriş Yap / Üye Ol
                        </h1>
                        <p class="text-secondary fs-15 mb-5 pb-3">
                            This text can be added in the category Description field in
                dashboard
                        </p>
                    </div>
                </div>
            </div>
            <div class="contact-wrap">
                <div class="row">
                    <div class="col-lg-6  mb-5 mb-sm-2">
                        <h1>Giriş Yap</h1>

                        <div class="row">
                            <div class="col-sm-12">
                                <div class="form-group">
                                    <input
                                        type="text"
                                        class="form-control"
                                        id="email"
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
                                        id="sifre"
                                        runat="server"
                                        aria-describedby="sifre"
                                        placeholder="Şifre" />
                                </div>
                            </div>
                        </div>



                        <div class="row">
                            <div class="col-sm-12">
                                <div class="form-group">
                                    <asp:Button ID="girisyap" class="btn btn-lg btn-dark font-weight-bold" runat="server" Text="Giriş Yap" OnClick="girisyap_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6 mb-2 mb-lg-2">
                        <div class="contact-right-padding">
                            <div class="row">
                                <div class="col-sm-12  mb-2 mb-lg-2">
                                    <h1>Üye Ol</h1>

                                    <div class="row">
                                        <div class="col-sm-12">
                                            <div class="form-group">
                                                <input
                                                    type="text"
                                                    runat="server"
                                                    class="form-control"
                                                    id="uyeol_adsoyad"
                                                    aria-describedby="uyeol_adsoyad"
                                                    placeholder="Ad Soyad" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-sm-12">
                                            <div class="form-group">
                                                <input
                                                    type="text"
                                                    runat="server"
                                                    class="form-control"
                                                    id="uyeol_email"
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
                                                    id="uyeol_sifre"
                                                    runat="server"
                                                    aria-describedby="sifre"
                                                    placeholder="Şifre" />
                                            </div>
                                        </div>
                                    </div>



                                    <div class="row">
                                        <div class="col-sm-12">
                                            <div class="form-group">
                                                <input
                                                    type="text"
                                                    class="form-control"
                                                    id="uyeol_sifre2"
                                                    runat="server"
                                                    aria-describedby="sifre"
                                                    placeholder="Şifre" />
                                            </div>
                                        </div>
                                    </div>


                                    <div class="row">
                                        <div class="col-sm-12">
                                            <div class="form-group">
                                                <asp:Button ID="uyeOl" class="btn btn-lg btn-dark font-weight-bold" runat="server" Text="Üye Ol" OnClick="uyeOl_Click" />
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
