<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AmazingTeam.PresentationLayer.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
        <div class="wide">
  	<div class="col-xs-5 line"><hr></div>
    <div class="col-xs-2 logo">Logo</div>
    <div class="col-xs-5 line"><hr></div>
</div>

<div class="container">
  <div class="text-center">
    <h1>Content</h1>
  </div>
</div><!-- /.container -->

    <style type="text/css">
        body {
  padding-top: 50px;
}

.wide {
  width:100%;
  height:200px;
  background-image:url('http://blinds-wallpaper.net/wallpaper/images/uploads/wallpaper/kitchen/KB8595.jpg');
  background-size:cover;
}

.wide img {
  width:100%;
}

.logo {
  color:#fff;
  font-weight:800;
  font-size:14pt;
  padding:25px;
  text-align:center;
}

.line {
  padding-top:20px;
  white-space:no-wrap;
  overflow:hidden;
  text-align:center;
}
        </style>

     <style type="text/css">
         /* Footer styles image
-------------------------------------------------- */
html {
  position: relative;
  min-height: 100%;
}
body {
  /* Margin bottom by footer height */
  margin-bottom: 60px;
}
#footer {
  position: absolute;
  bottom: 0;
  width: 100%;
  /* Set the fixed height of the footer here */
  height: 280px;
  background: 
  /* color overlay */ 
    linear-gradient(
      rgba(240, 212, 0, 0.45), 
      rgba(0, 0, 0, 0.45)
    ),
    /* image to overlay */
    url(http://images.cdn.fotopedia.com/_avPIZmqM3w-7z161LH_268-hd.jpg);
}


/* Custom footer CSS
-------------------------------------------------- */

.container {
  width: auto;
  max-width: 680px;
  padding: 0 15px;
}
.container .text-muted {
  margin: 20px 0;
}
.footertext {
  color: #ffffff;
}



/*           IMAGE NEW CSSS*/
/*

* Based on Cover by https://twitter.com/mdo"  @mdo
* added cover image and background color to match (green)
*
* Globals

*/

/* Links */
a,
a:focus,
a:hover {
  color: #fff;
}

/* Custom default button */
.btn-default,
.btn-default:hover,
.btn-default:focus {
  color: #333;
  text-shadow: none; /* Prevent inheritence from `body` */
  background-color: #fff;
  border: 1px solid #fff;
}


/*
 * Base structure
 */

html,
body {
/*css for full size background image*/
  background: url(http://blinds-wallpaper.net/wallpaper/images/uploads/wallpaper/kitchen/KB8595.jpg) no-repeat center center fixed; 
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  background-size: cover;
  
  height: 100%;
  background-color: #060;
  color: #fff;
  text-align: center;
  text-shadow: 0 1px 3px rgba(0,0,0,.5);
 
}

/* Extra markup and styles for table-esque vertical and horizontal centering */
.site-wrapper {
  display: table;
  width: 100%;
  height: 100%; /* For at least Firefox */
  min-height: 100%;
  -webkit-box-shadow: inset 0 0 100px rgba(0,0,0,.5);
          box-shadow: inset 0 0 100px rgba(0,0,0,.5);
}
.site-wrapper-inner {
  display: table-cell;
  vertical-align: top;
}
.cover-container {
  margin-right: auto;
  margin-left: auto;
}

/* Padding for spacing */
.inner {
  padding: 30px;
}


/*
 * Header
 */
.masthead-brand {
  margin-top: 10px;
  margin-bottom: 10px;
}

.masthead-nav > li {
  display: inline-block;
}
.masthead-nav > li + li {
  margin-left: 20px;
}
.masthead-nav > li > a {
  padding-right: 0;
  padding-left: 0;
  font-size: 16px;
  font-weight: bold;
  color: #fff; /* IE8 proofing */
  color: rgba(255,255,255,.95);
  border-bottom: 2px solid transparent;
}
.masthead-nav > li > a:hover,
.masthead-nav > li > a:focus {
  background-color: transparent;
  border-bottom-color: #a9a9a9;
  border-bottom-color: rgba(255,255,255,.25);
}
.masthead-nav > .active > a,
.masthead-nav > .active > a:hover,
.masthead-nav > .active > a:focus {
  color: #fff;
  border-bottom-color: #fff;
}

@media (min-width: 768px) {
  .masthead-brand {
    float: left;
  }
  .masthead-nav {
    float: right;
  }
}


/*
 * Cover
 */

.cover {
  padding: 0 20px;
}
.cover .btn-lg {
  padding: 10px 20px;
  font-weight: bold;
}


/*
 * Footer
 */

.mastfoot {
  color: #999; /* IE8 proofing */
  color: rgba(255,255,255,.5);
}


/*
 * Affix and center
 */

@media (min-width: 768px) {
  /* Pull out the header and footer */
  .masthead {
    position: fixed;
    top: 0;
  }
  .mastfoot {
    position: fixed;
    bottom: 0;
  }
  /* Start the vertical centering */
  .site-wrapper-inner {
    vertical-align: middle;
  }
  /* Handle the widths */
  .masthead,
  .mastfoot,
  .cover-container {
    width: 100%; /* Must be percentage or pixels for horizontal alignment */
  }
}

@media (min-width: 992px) {
  .masthead,
  .mastfoot,
  .cover-container {
    width: 700px;
  }
}


     </style>
       
       



     <div class="container text-center">

<h1> Click Me </h1>
<!-- Large modal -->
<button class="btn btn-default" data-toggle="modal" data-target=".bs-example-modal-lg">Large modal</button>


<div class="modal fade bs-example-modal-lg" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
  <div class="modal-dialog modal-lg">
    <div class="modal-content">
      <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">

  

  <!-- Wrapper for slides -->
  <div class="carousel-inner">
    <div class="item active">
     <img class="img-responsive" src="http://placehold.it/1200x600/555/000&text=One" alt="...">
      <div class="carousel-caption">
        One Image
      </div>
    </div>
    <div class="item">
      <img class="img-responsive" src="http://placehold.it/1200x600/fffccc/000&text=Two" alt="...">
      <div class="carousel-caption">
        Another Image
      </div>
    </div>
     <div class="item">
      <img class="img-responsive" src="http://placehold.it/1200x600/fcf00c/000&text=Three" alt="...">
      <div class="carousel-caption">
        Another Image
      </div>
    </div>
  </div>

  <!-- Controls -->
  <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left"></span>
  </a>
  <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right"></span>
  </a>
</div>
    </div>
  </div>
</div>
</div>
   

<form runat="server" id="David">
 
Enter your name 
    <asp:TextBox ID="Name" runat="server">
    </asp:TextBox>
    <asp:Button OnClick="Submit" Text ="Submit" runat="server" />

 

Enter your name 
    <asp:TextBox ID="TextBox1" runat="server">
    </asp:TextBox>
    <asp:Button OnClick="Submit" Text ="Number 2" runat="server" />

</form>










    <div class="site-wrapper">
  <div class="site-wrapper-inner">
    <div class="cover-container">
      <div class="masthead clearfix">
        <div class="inner">
          <h3 class="masthead-brand">Cover</h3>

          <ul class="nav masthead-nav">
            <li class="active">
              <a href="http://bootsnipp.com/iframe/g6GWQ" target=
              "_blank">View full screen</a>
            </li>

            <li>
              <a href="#">Features</a>
            </li>

            <li>
              <a href="#">Contact</a>
            </li>
          </ul>
        </div>
      </div>

      <div class="inner cover">
        <h1 class="cover-heading">Full screen background cover page.</h1>

        <p class="lead">Cover is a one-page template for building simple and
        beautiful home pages. Download, edit the text, and add your own
        fullscreen background color and photo to make it your own.
            
        <small>    <br> <a href="http://bootsnipp.com/iframe/g6GWQ" target=
              "_blank">Best viewed on full screen</a></small>
            
        </p>

        <p class="lead"><a class="btn btn-lg btn-info" href="#">Learn
        more</a></p>
      </div>

      <div class="mastfoot">
        <div class="inner">
          <!-- Validation -->

          <p><a href=
          "http://validator.w3.org/check?uri=http%3A%2F%2Fbootsnipp.com%2Fiframe%2Fg6GWQ"
          target="_blank"><small>HTML</small><sup>5</sup></a></p>
          
          
          <p><a href=
          "https://github.com/twbs/bootlint"
          target="_blank"><small>Checked with Bootlint</small></a></p>          
      
          

          <p>© 2014 Your Name ~ <a href=
          "http://getbootstrap.com/">Bootstrap</a></p>
        </div>
      </div>
    </div>
</div>
</div>











    <div class="container well">
	<h2><center>Web Stuff Goes Here</center></h2>
</div>
<div id="footer">
    <div class="container">
        <div class="row">
            <h3 class="footertext">About Us:</h3>
            <br>
              <div class="col-md-4">
                <center>
                  <img src="http://oi60.tinypic.com/w8lycl.jpg" class="img-circle" alt="the-brains">
                  <br>
                  <h4 class="footertext">Programmer</h4>
                  <p class="footertext">You can thank all the crazy programming here to this guy.<br>
                </center>
              </div>
              <div class="col-md-4">
                <center>
                  <img src="http://oi60.tinypic.com/2z7enpc.jpg" class="img-circle" alt="...">
                  <br>
                  <h4 class="footertext">Artist</h4>
                  <p class="footertext">All the images here are hand drawn by this man.<br>
                </center>
              </div>
              <div class="col-md-4">
                <center>
                  <img src="http://oi61.tinypic.com/307n6ux.jpg" class="img-circle" alt="...">
                  <br>
                  <h4 class="footertext">Designer</h4>
                  <p class="footertext">This pretty site and the copy it holds are all thanks to this guy.<br>
                </center>
              </div>
            </div>
            <div class="row">
            <p><center><a href="#">Contact Stuff Here</a> <p class="footertext">Copyright 2014</p></center></p>
        </div>
    </div>
</div>

























<div id="footer">
  <div class="container">
    <p class="text-muted credit">Example courtesy <a href="http://martinbean.co.uk">Martin Bean</a> and <a href="http://ryanfait.com/sticky-footer/">Ryan Fait</a>.</p>
  </div>
</div>


<script type="text/javascript">
function update(){

var total = 0.00;
var calcUnitPrice, quantity;

var myForm = document["getElementById"]("totalform");
var justQuantity = myForm["quantity[]"];
var justPrice = myForm["productPrice[]"];
var unitPrice = myForm["unitPrice[]"];
var linePrice = myForm["linePrice[]"];

for(var i =0; i < justQuantity.length; i++)
{
 justQuantity[i].value = Math.floor(justQuantity[i].value);
 quantity = justQuantity[i].value;
 calcUnitPrice = 0;

 if(isNaN(quantity) || quantity < 0) {
   justQuantity[i].value ="0";
 }
 else
 {
  calcUnitPrice = calcUnitPriceF(justPrice[i].value,quantity);

  document.getElementById('unitPrice[' + i + ']').innerHTML = '£' + calcUnitPrice.toFixed(2);
  document.getElementById('linePrice[' + i + ']').innerHTML = '£' + (calcUnitPrice * justQuantity[i].value).toFixed(2); 
  total = (total + (quantity* calcUnitPrice));
 }
}

document.getElementById("delivery").innerHTML = "Your Order Delivery is: £2.50";
document.getElementById("Totprice2").innerHTML = "Your Order Total is: £" + total.toFixed(2);

}

function calcUnitPriceF(product,quantity)
{
 switch(product)
  {
   case '0':
    return 0;
   case '1':
    var values = [5, 4 , 15.30 , 10 , 12 ]; // Structure(Exceeding Quantity Price,Quantity Under, Price)

    for(var i = 1; i< values.length; i=i+2)
     if(quantity < values[i])
      return values[i+1];
    return values[0];
   case '2':
    return 75;
   }
}
</script>

<body>

<form id="totalform">
<select id ="productPrice[]" onchange="update()">
  <option value="0">Please Select One</option>
  <option value="1">Product 1</option>
  <option value="2">Product 2</option>
</select>
QUANTITY <input type = "text" id = "quantity[]" onChange="update()" >
UNIT PRICE <p id="unitPrice[0]" style="display:inline;">£0.00</p>
LINE PRICE <p id="linePrice[0]" style="display:inline;">£0.00</p><br />

<select id="productPrice[]" onchange="update()">
  <option value="0">Please Select One</option>
  <option value="1">Product 1</option>
  <option value="2">Product 2</option>
</select>
QUANTITY <input type = "text" id = "quantity[]" onChange="update()" >
UNIT PRICE <p id="unitPrice[1]" style="display:inline;">£0.00</p>
LINE PRICE <p id="linePrice[1]" style="display:inline;">£0.00</p><br />

<span id ="delivery">Your Order Delivery is: £0.00</span><br />
<span id ="Totprice2">Your Order Total is: £0.00</span>
</form>
</asp:Content>
