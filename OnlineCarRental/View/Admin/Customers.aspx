<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="OnlineCarRental.View.Admin.Customers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="row">
        <div class="row">
            <div class="col-md-4">
                <div class="row">
                    <div class="col"></div>
                    <h3 class="text-danger">Manage Customers</h3>
                    <div class="col"><img src="../../Assets/Img/customer.jpg" /></div>
                    <div class="col"></div>
                </div>
                <div class="row">
                    <div class="col"></div>

                    <form>

                        <div class="form-group">
                            <label for="exampleInputEmail1" class="form-label">Customer Name</label>
                            <input type="Text" class="form-control" id="CustomerNameTb" placeholder="Enter Name" runat="server">
                            
                        </div>

                        <div class="form-group">
                            <label for="exampleInputEmail1" class="form-label">Customer ID</label>
                            <input type="Text" class="form-control" id="CustomerId" placeholder="Enter ID Number" runat="server">
                        </div>

                        <div class="form-group">
                            <label for="exampleInputEmail1" class="form-label">Licence No.</label>
                            <input type="Text" class="form-control" id="LicenceTb" placeholder="Enter Licence Number" runat="server">
                        </div>

                        <div class="form-group">
                            <label for="exampleInputEmail1" class="form-label">Customer's Address</label>
                            <input type="Text" class="form-control" id="AddTb" placeholder="Enter Address" runat="server">
                        </div>

                        <div class="form-group">
                            <label for="exampleInputEmail1" class="form-label">Customer's Email</label>
                            <input type="Text" class="form-control" id="EmailTb" placeholder="Enter a valid Email" runat="server">
                        </div>

                        <div class="form-group">
                            <label for="exampleInputEmail1" class="form-label">Customer's NID Number</label>
                            <input type="Text" class="form-control" id="NIdTb" placeholder="Enter NID No." runat="server">
                        </div>

                        <div class="form-group">
                            <label for="exampleInputEmail1" class="form-label">Customer Phone</label>
                            <input type="Text" class="form-control" id="PhoneTb" placeholder="Enter Phone Number" runat="server">
                        </div>

                        <div class="form-group">
                            <label for="exampleInputEmail1" class="form-label">Customer's Password</label>
                            <input type="Text" class="form-control" id="PassTb" placeholder="Enter Password" runat="server">
                        </div>
                        
                        <div class="form-group">
                            <asp:CheckBox ID="checkBox" runat="server" Text = "Are You Sure?" />
                        </div>
                        </form>
                    </div>

      
                <asp:Button type="submit" ID="EditBtn" class="btn btn-danger" Text="Edit" runat="server" OnClick="EditBtn_Click" />
                <asp:Button type="submit" ID="SaveBtn" class="btn btn-danger" Text="Add" runat="server" OnClick="SaveBtn_Click" />
                <asp:Button type="submit" ID="DeleteBtn" class="btn btn-danger" Text="Delete" runat="server" OnClick="DeleteBtn_Click" />
                <asp:Button type="submit" ID="ClearBtn" class="btn btn-danger" Text="Clear" runat="server" OnClick="ClearBtn_Click" />
                <label id="ErrorMsg" runat="server"></label>
                </div>
                    
            
            <div class="col-md-8">
                <h1>Customer List</h1>
                <asp:GridView runat="server" ID="CustomersList" Class="table table-danger" AutoGenerateSelectButton="True" OnSelectedIndexChanged="CarList_SelectedIndexChanged">
                </asp:GridView>
            </div>
        </div>
    </div>
</div>
</asp:Content>
