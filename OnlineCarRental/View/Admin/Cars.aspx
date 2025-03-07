<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="OnlineCarRental.View.Admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
        <div class="row">
            <div class="row">
                <div class="col-md-4">
                    <div class="row">
                        <div class="col"></div>
                        <h3 class="text-danger">Manage Cars</h3>
                        <div class="col"><img src="../../Assets/Img/resize-1705375917192532334p90475606highresrollsroycephantom1677268219.jpg" /></div>
                        <div class="col"></div>
                    </div>
                    <div class="row">
                        <div class="col"></div>

                        <form>
                            <br />
                            <div class="form-group">
                                <label for="exampleInputEmail1" class="form-label">Car Plate Number</label>
                                <input type="Text" class="form-control" id="LNumberTb" placeholder="Enter Licence Number" runat="server">
                                
                            </div>

                            <div class="form-group">
                                <label for="exampleInputEmail1" class="form-label">Brand</label>
                                <input type="Text" class="form-control" id="BrandTb" placeholder="Enter The Car's Brand" runat="server">
                            </div>

                            <div class="form-group">
                                <label for="exampleInputEmail1" class="form-label">Model</label>
                                <input type="Text" class="form-control" id="ModelTb" placeholder="Enter Car's Model" runat="server">
                            </div>

                            <div class="form-group">
                                <label for="exampleInputEmail1" class="form-label">Rent Price</label>
                                <input type="Text" class="form-control" id="PriceTb" placeholder="Enter Rent Price" runat="server">
                            </div>

                            <div class="form-group">
                                <label for="exampleInputEmail1" class="form-label">Color</label>
                                <input type="Text" class="form-control" id="ColorTb" placeholder="Enter Color" runat="server">
                                <br />
                            </div>
                            

                            <div class="form-group">
                                <label for="exampleInputEmail1" class="form-label">Car Status : </label>
                                <asp:DropDownList ID="AvailableTb" runat="server">
                                    <asp:ListItem>Available</asp:ListItem>
                                    <asp:ListItem>Booked</asp:ListItem>
                                </asp:DropDownList>
                                
                            </div>

                            
                            <div class="mb-3 form-check">
                                <asp:CheckBox ID="checkBox" runat="server" Text = "Are You Sure?" />

                            </div>
              <br />
                            <br />
                            
                        </form>
                        

                    </div>
                    <asp:button type="submit" ID="EditBtn" class="btn btn-danger" Text="Edit" runat="server" OnClick="EditBtn_Click" />
                    <asp:button type="submit" ID="SaveBtn" class="btn btn-danger" Text="Add" runat="server" OnClick="SaveBtn_Click" />
                    <asp:button type="submit" ID="DeleteBtn" class="btn btn-danger" Text="Delete" runat="server" OnClick="DeleteBtn_Click" />
                    <asp:button type="submit" ID="ClearBtn" class="btn btn-danger" Text="Clear" runat="server" OnClick="ClearBtn_Click" />
                    <label id="ErrorMsg" runat="server"></label>
                </div>
                <div class="col-md-8">
                    <h1>Car List</h1>
                    <asp:GridView runat="server" ID="CarList" Class="table table-danger" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CarList_SelectedIndexChanged">

                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
