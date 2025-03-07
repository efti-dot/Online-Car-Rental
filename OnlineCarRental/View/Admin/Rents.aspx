<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Rents.aspx.cs" Inherits="OnlineCarRental.View.Admin.Rents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="row">
                <div class="col-md-12">
                    <div class="row">
                        <div class="col"></div>
                        <h3 class="text-danger">Rented Cars</h3>
                        <div class="col"><img src="../../Assets/Img/customer.jpg" /></div>
                        <div class="col"></div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12">
                            <asp:GridView runat="server" ID="GridView1" CssClass="table table-hover" AutoGenerateSelectButton="True" OnSelectedIndexChanged="RentList_SelectedIndexChanged">
                                <AlternatingRowStyle BackColor="#f2f2f2" ForeColor="#333333" />
                            </asp:GridView>

                            <div class="form-control">
                                <input type="text" class="form-control" id="DelayTb" runat="server" />
                                <label class="form-check-label" for="AdminRadio">Delay</label>
                            </div>
                            <div class="form-control">
                                <input type="text" class="form-control" id="FineTb" runat="server" />
                                <label class="form-check-label" for="CustomerRadio">Fine</label>
                            </div>

                            <label id="ErrorMsg" runat="server"></label>
                            <div class="text-center">
                                <asp:Button type="submit" ID="RtnBtn" class="btn btn-danger btn-block" Text="Return" runat="server" OnClick="ReturnBtn_Click" />
                            </div>
                        </div>
                        <br />
                        <br />
                    </div>
                </div>
                <div class="col-md-8">
                    <table class="table">
                        <!-- Your table content here -->
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
