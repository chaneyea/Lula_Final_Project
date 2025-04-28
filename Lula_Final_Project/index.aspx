<!--
*File Name: index.aspx

* Name: Ethan Chaney, Andrea Forero, Gabe Guyler, Nollan Callahan
* email:  chaneyea@mail.uc.edu 
* Assignment Number: Lula_Final_Project
* Due Date:   4/29/2025
* Course #/Section:   IS3050 Section 001
* Semester/Year:   Spring 2025
* Brief Description of the assignment:  Final project, making a website to show leetcode solutions

* Makes a class to solve problem 42 on leetcode
* Citations:
* Anything else that's relevant:
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Final_Project.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    <style>
#lnkProblem4 {background-color: purple; color:white;}
#lnkProblem42 {background-color: red; color:white;}
#lnkProblem1028 {background-color: blue; color:white;}
#lnkProblem65 {background-color: teal; color:white;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
  <nav class="navbar navbar-expand-lg navbar-light bg-light mb-4">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Final Project Problems</a>
    <div class="collapse navbar-collapse">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <asp:LinkButton ID="lnkProblem4" runat="server" CssClass="nav-link" OnClick="lnkProblem4_Click">Problem 4</asp:LinkButton>
        </li>
        <li class="nav-item">
          <asp:LinkButton ID="lnkProblem42" runat="server" CssClass="nav-link" OnClick="lnkProblem42_Click">Problem 42</asp:LinkButton>
        </li>
        <li class="nav-item">
          <asp:LinkButton ID="lnkProblem1028" runat="server" CssClass="nav-link" OnClick="lnkProblem1028_Click">Problem 1028</asp:LinkButton>
        </li>
        <li class="nav-item">
          <asp:LinkButton ID="lnkProblem65" runat="server" CssClass="nav-link" OnClick="lnkProblem65_Click">Problem 65</asp:LinkButton>
        </li>
      </ul>
    </div>
  </div>
</nav>
        

             <!-- Andrea's Problem 04 Below -->
       <div id="divProblem4" runat="server" visible="false">
       <asp:Button ID="btnProblem4" runat="server" Text="Problem 4" OnClick="btnProblem4_Click" />
           <br/>
           <asp:Label ID="Label2" runat="server" Text="Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays."></asp:Label>
       <br /><br />
       <asp:Label ID="lblResult" runat="server" Text="" />
           <br /><br />
       <asp:Label ID="lblTest" runat="server" Text=""></asp:Label>
       </div>
            <!-- Ethan's Problem 42 Section Below -->
        <div id="divProblem42" runat="server" visible="false">
        <asp:Button ID="btnShowSolution" runat="server" Text="Problem 42" OnClick="btnShowSolution_Click" />
        <br />
       <asp:Label ID="Label1" runat="server" Text="Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays." />

        <asp:Label ID="lblDescription" runat="server" Font-Bold="true" Text=""></asp:Label>
        <br />

        <asp:Label ID="lblTestCase1" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblResult1" runat="server" Text=""></asp:Label>
        <br />

        <asp:Label ID="lblTestCase2" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblResult2" runat="server" Text=""></asp:Label>
        </div>

        <!-- Gabe's Problem 1028 Section -->
        <div id="divProblem1028" runat="server" visible="false">
        <asp:Button ID="btnShowSolution1028" runat="server" Text="Problem 1028" OnClick="btnShowSolution1028_Click" />
        <br />
        <asp:Label ID="lblDescription1028" runat="server" Font-Bold="true" Text="We run a preorder depth-first search (DFS) on the root of a binary tree.

At each node in this traversal, we output D dashes (where D is the depth of this node), then we output the value of this node.  If the depth of a node is D, the depth of its immediate child is D + 1.  The depth of the root node is 0.

If a node has only one child, that child is guaranteed to be the left child.

Given the output traversal of this traversal, recover the tree and return its root."></asp:Label>
        <br />
        <asp:Label ID="lblTestCase1028" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblResult1028" runat="server" Text=""></asp:Label>
        </div>
        <!-- Nolan's Problem 65 -->
        <div id="divProblem65" runat="server" visible="false">
        <asp:Button ID="btnShowSolution65" runat="server" Text="Problem 65" OnClick="btnShowSolution65_Click" />
        <br />
        <asp:Label ID="lblDescription65" runat="server" Font-Bold="true" Text="Given a string s, return whether s is a valid number."></asp:Label>
        <br />
        <asp:Label ID="lblTestCase65" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblResult65" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
