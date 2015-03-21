<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="AmazingTeam.PresentationLayer.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <form id="form1" runat="server">
    <div class="container">
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
    <!-- Indicators -->
    <ol class="carousel-indicators">
        <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
        <li data-target="#myCarousel" data-slide-to="1"></li>
        <li data-target="#myCarousel" data-slide-to="2"></li>
    </ol>
    <div class="carousel-inner">
        <div class="item active">
            <img src="https://scontent-sea.xx.fbcdn.net/hphotos-xap1/t31.0-8/11051937_1039682316046511_7801753993608171767_o.jpg" alt="First slide">
            <div class="container">
                <div class="carousel-caption">
                    <h1>Platters</h1>
                    <p>Party platters are available in two sizes and can be customized based on your preferences.</p>
                    
                </div>
            </div>
        </div>
        <div class="item">
            <img src="https://fbcdn-sphotos-f-a.akamaihd.net/hphotos-ak-xap1/t31.0-8/10838248_1039682322713177_9189293895910908934_o.jpg" alt="Second slide">
            <div class="container">
                <div class="carousel-caption">
                    <h1>Ingredients</h1>
                    <p>These are just a few of the many quality ingredients used in making our products.</p>
                    
                </div>
            </div>
        </div>
        <div class="item">
            <img src="https://fbcdn-sphotos-e-a.akamaihd.net/hphotos-ak-xpf1/t31.0-8/10985428_1039682326046510_393023468666982059_o.jpg" alt="Third slide">
            <div class="container">
                <div class="carousel-caption">
                    <h1>Nuts n’more</h1>
                    <p>Pecans, peanuts, semi-sweet chocolate chips and dates to name a few.</p>
                </div>
            </div>
        </div>
    </div>
    <a class="left carousel-control" href="#myCarousel" data-slide="prev" role="button"><span class="glyphicon glyphicon-chevron-left"></span></a>
    <a class="right carousel-control" href="#myCarousel" data-slide="next" role="button"><span class="glyphicon glyphicon-chevron-right"></span></a>

</div><!-- /.carousel -->



<!-- Marketing messaging and featurettes
    ================================================== -->
<!-- Wrap the rest of the page in another container to center all the content. -->

    

<div class="container marketing" style="padding-top: 10px;" >

    <!-- Three columns of text below the carousel -->
    <div class="row">
        <div class="col-lg-12">
            <img class="img-circle" src="https://scontent-sea.xx.fbcdn.net/hphotos-xpf1/v/t1.0-9/10994427_1039847326030010_7557293848522850423_n.jpg?oh=a982c5f1e9b0ddf5e07b4bc1426b23a0&oe=557BAD9F" alt="Generic placeholder image">
            <h2>Coming Soon</h2>
                                       
            <p>Looking forward to bringing a little taste of my home into yours!</p>
        
        </div>
    </div>





      <footer style="padding-top:30px;">
        <p>&copy; 2015 C2, Inc. &middot; Web Site Develop by: Amazing Team &middot; <a href="Authenticate.aspx" style="color:deeppink">Staff Login</a></p>
    </footer>

</div><!-- /.container -->

</div>
    </form>
</asp:Content>
