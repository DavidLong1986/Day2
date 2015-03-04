<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="AmazingTeam.PresentationLayer.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    

    <script type="text/javascript" >
        $(document).ready(function () {
            var $lightbox = $('#lightbox');

            $('[data-target="#lightbox"]').on('click', function (event) {
                var $img = $(this).find('img'),
                    src = $img.attr('src'),
                    alt = $img.attr('alt'),
                    css = {
                        'maxWidth': $(window).width() - 100,
                        'maxHeight': $(window).height() - 100
                    };

                $lightbox.find('.close').addClass('hidden');
                $lightbox.find('img').attr('src', src);
                $lightbox.find('img').attr('alt', alt);
                $lightbox.find('img').css(css);
            });

            $lightbox.on('shown.bs.modal', function (e) {
                var $img = $lightbox.find('img');

                $lightbox.find('.modal-dialog').css({ 'width': $img.width() });
                $lightbox.find('.close').removeClass('hidden');
            });
        });
    </script>


    <style type="text/css">


#lightbox .modal-content {
    display: inline-block;
    text-align: center;   
}

#lightbox .close 
{
    opacity: 1;
    color: rgb(255, 255, 255);
    background-color: rgb(25, 25, 25);
    padding: 5px 8px;
    border-radius: 30px;
    border: 2px solid rgb(255, 255, 255);
    position: absolute;
    top: -15px;
    right: -55px;
    z-index:1032;
}

    </style>




    <!--My Jumbotron -->
    <div class="container">
  <div class="jumbotron">
    <h1 style="text-align:center;">Shop Our Desserts and Amazing Hot Food!! TEST SITE</h1>      
  </div> 
</div>
    <!--End of Jumbotron -->

   

        <!--the Start of Menu -->
        <div class="container">




                <form target="paypal" action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post" >
                <input type="hidden" name="cmd" value="_s-xclick">
                <input type="hidden" name="encrypted" value="-----BEGIN PKCS7-----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-----END PKCS7-----
                ">
                <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_viewcart_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
                <img alt="" border="0" src="https://www.sandbox.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1">
                </form>





 
                <div class="col-md-4 profile" id="Product1Panel" runat="server">
                    <div class="panel panel-default">
                        <div class="panel-thumbnail">	
                            <a href="#" class="thumbnail" data-toggle="modal" data-target="#lightbox"> 
                                <img src="https://fbcdn-sphotos-f-a.akamaihd.net/hphotos-ak-xap1/t31.0-8/11050273_1039271929420883_4178054087631851032_o.jpg" alt="...">
                            </a>
                        </div>
                        <div class="panel-body" align="center" style="height:250px;" >

                            <p style="font-weight:bold;">Bark (milk chocolate)</p>
                            <p>Callebaut chocolate and macadamia nuts</p>
                            <p style="color:#00A300">$4.75/100g</p>

                         
                            <form target="paypal" action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
                            <input type="hidden" name="cmd" value="_s-xclick">
                            <input type="hidden" name="hosted_button_id" value="RCJFBK2VCU5LY">
                            <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_cart_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
                            <img alt="" border="0" src="https://www.sandbox.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1">
                            </form>

                        </div>
                    </div>
                </div>
                <div class="col-md-4 profile" id="Product2Panel" runat="server">
                    <div class="panel panel-default">
                        <div class="panel-thumbnail">	
                            <a href="#" class="thumbnail" data-toggle="modal" data-target="#lightbox"> 
                                <img src="https://fbcdn-sphotos-a-a.akamaihd.net/hphotos-ak-xpf1/t31.0-8/11004536_1039272056087537_6407317102266159314_o.jpg" alt="...">
                            </a>

                        </div>
                        <div class="panel-body" align="center" style="height:250px;" >
                            
                            <p style="font-weight:bold">Butter-me-up Tarts</p>
                            <p>Pastry crust, butter, brown sugar, corn syrup, egg, vanilla, white vinegar, raisins and pecans.</p>
                            <p style="color:#00A300">$1.50 or 12/$15.00</p>
  
                           
                            <form target="paypal" action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
                            <input type="hidden" name="cmd" value="_s-xclick">
                            <input type="hidden" name="hosted_button_id" value="37U2DG37ALHZC">
                            <table>
                            <tr><td><input type="hidden" name="on0" value="How many?">How many?</td></tr><tr><td><select name="os0">
	                            <option value="1 for">1 for $1.50 CAD</option>
	                            <option value="12 for">12 for $15.00 CAD</option>
                            </select> </td></tr>
                            </table>
                            <input type="hidden" name="currency_code" value="CAD">
                            <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_cart_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
                            <img alt="" border="0" src="https://www.sandbox.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1">
                            </form>

                          


                        </div>
                    </div>
                </div>
                <div class="col-md-4 profile" id="Product3Panel" runat="server">
                    <div class="panel panel-default">
                        <div class="panel-thumbnail">	

                            <a href="#" class="thumbnail" data-toggle="modal" data-target="#lightbox"> 
                                <img src="https://scontent-sea.xx.fbcdn.net/hphotos-xfa1/t31.0-8/10860988_1039271986087544_1713944679390042737_o.jpg" alt="...">
                            </a>

                        </div>
                        <div class="panel-body" align="center" style="height:250px;">
                            <p style="font-weight:bold">Chocolate Covered Blueberries</p>
                            <p>Callebaut chocolate and fresh blueberries</p>
                            <p style="color:#00A300">$1.50 or 12/$15.00</p>
                           



                            <form target="paypal" action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
                            <input type="hidden" name="cmd" value="_s-xclick">
                            <input type="hidden" name="hosted_button_id" value="BW474MUHDUJYQ">
                            <table>
                            <tr><td><input type="hidden" name="on0" value="How many?">How many?</td></tr><tr><td><select name="os0">
	                            <option value="1 for">1 for $1.50 CAD</option>
	                            <option value="12 for">12 for $15.00 CAD</option>
                            </select> </td></tr>
                            </table>
                            <input type="hidden" name="currency_code" value="CAD">
                            <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_cart_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
                            <img alt="" border="0" src="https://www.sandbox.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1">
                            </form>






                        </div>
                    </div>
                </div>
                <div class="col-md-4 profile" id="Product4Panel" runat="server">
                    <div class="panel panel-default">
                        <div class="panel-thumbnail">	

                            <a href="#" class="thumbnail" data-toggle="modal" data-target="#lightbox"> 
                                <img src="https://fbcdn-sphotos-d-a.akamaihd.net/hphotos-ak-xpf1/t31.0-8/10943791_1039272046087538_3668210677303411163_o.jpg" alt="...">
                            </a>

                        </div>
                       <div class="panel-body" align="center" style="height:250px;">
                            <p style="font-weight:bold">Chocolate Covered Strawberries</p>
                            <p>Callebaut chocolate and fresh strawberries</p>
                            <p style="color:#00A300">$1.50 or 12/$15.00</p>
                         



                            <form target="paypal" action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
                            <input type="hidden" name="cmd" value="_s-xclick">
                            <input type="hidden" name="hosted_button_id" value="DL52Q9PLQ66VS">
                            <table>
                            <tr><td><input type="hidden" name="on0" value="How many?">How many?</td></tr><tr><td><select name="os0">
	                            <option value="1 for">1 for $1.50 CAD</option>
	                            <option value="12 for">12 for $15.00 CAD</option>
                            </select> </td></tr>
                            </table>
                            <input type="hidden" name="currency_code" value="CAD">
                            <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_cart_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
                            <img alt="" border="0" src="https://www.sandbox.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1">
                            </form>





                        </div>
                    </div>
                </div>
                <div class="col-md-4 profile" id="Product5Panel" runat="server">
                    <div class="panel panel-default">
                        <div class="panel-thumbnail">	
                            <a href="#" class="thumbnail" data-toggle="modal" data-target="#lightbox"> 
                                <img src="https://scontent-sea.xx.fbcdn.net/hphotos-xpa1/t31.0-8/10835454_1039271939420882_1633603889678640293_o.jpg" alt="...">
                            </a>

                        </div>
                        <div class="panel-body" align="center" style="height:250px;">

                            <p style="font-weight:bold">Eatmore Please</p>
                            <p>Semi-sweet chocolate, corn syrup, peanut butter, peanuts and rice krispies cereal.</p>
                            <p style="color:#00A300">9” x 15” slab $25</p>
                            <p style="color:#00A300">Pre-cut $30</p>
 
                          




                            <form target="paypal" action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
                            <input type="hidden" name="cmd" value="_s-xclick">
                            <input type="hidden" name="hosted_button_id" value="DAGDWL9LUFDTW">
                            <table>
                            <tr><td><input type="hidden" name="on0" value="Slab or Pre-cut?">Slab or Pre-cut?</td></tr><tr><td><select name="os0">
	                            <option value="9" x 15" slab">9" x 15" slab $25.00 CAD</option>
	                            <option value="Pre-cut">Pre-cut $30.00 CAD</option>
                            </select> </td></tr>
                            </table>
                            <input type="hidden" name="currency_code" value="CAD">
                            <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_cart_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
                            <img alt="" border="0" src="https://www.sandbox.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1">
                            </form>






                        </div>
                    </div>
                </div>
                <div class="col-md-4 profile" id="Product6Panel" runat="server">
                    <div class="panel panel-default">
                        <div class="panel-thumbnail">	
                            <a href="#" class="thumbnail" data-toggle="modal" data-target="#lightbox"> 
                                <img src="https://scontent-sea.xx.fbcdn.net/hphotos-xfp1/t31.0-8/905551_1039271916087551_4907013135718531796_o.jpg" alt="...">
                            </a>

                        </div>
                        <div class="panel-body" align="center" style="height:250px;">

                            <p style="font-weight:bold">Heavenly Haystacks</p>
                            <p>Callebaut chocolate chips, Reese peanut butter chips, peanuts and chow mein noodles</p>
                            <p style="color:#00A300">$1.50 or 12/$15.00</p>




                            <form target="paypal" action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
                            <input type="hidden" name="cmd" value="_s-xclick">
                            <input type="hidden" name="hosted_button_id" value="YKQXN8TEVWMDG">
                            <table>
                            <tr><td><input type="hidden" name="on0" value="How many?">How many?</td></tr><tr><td><select name="os0">
	                            <option value="1 for">1 for $1.50 CAD</option>
	                            <option value="12 for">12 for $15.00 CAD</option>
                            </select> </td></tr>
                            </table>
                            <input type="hidden" name="currency_code" value="CAD">
                            <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_cart_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
                            <img alt="" border="0" src="https://www.sandbox.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1">
                            </form>






                            
                        </div>
                    </div>
                </div>


                <div class="col-sm-4 col-xs-12 profile" id="Product7Panel" runat="server">
                    <div class="panel panel-default">
                        <div class="panel-thumbnail">	
                            <a href="#" class="thumbnail" data-toggle="modal" data-target="#lightbox"> 
                                <img src="https://scontent-sea.xx.fbcdn.net/hphotos-xpf1/t31.0-8/10982128_1039252626089480_2685183658841576259_o.jpg" alt="...">
                            </a>
                        </div>
                        <div class="panel-body" align="center" style="height:250px;">

                            
                            <p style="font-weight:bold">Oooh Henry Balls</p>
                            <p>Peanut butter, dates, peanuts, icing sugar, butter, semi-sweet chocolate</p>
                            <p style="color:#00A300">$1.50 or 12/$15.00</p>


                            <form target="paypal" action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
                            <input type="hidden" name="cmd" value="_s-xclick">
                            <input type="hidden" name="hosted_button_id" value="RGUTBTCXU5UPL">
                            <table>
                            <tr><td><input type="hidden" name="on0" value="How many?">How many?</td></tr><tr><td><select name="os0">
	                            <option value="1 for">1 for $1.50 CAD</option>
	                            <option value="12 for">12 for $15.00 CAD</option>
                            </select> </td></tr>
                            </table>
                            <input type="hidden" name="currency_code" value="CAD">
                            <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_cart_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
                            <img alt="" border="0" src="https://www.sandbox.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1">
                            </form>





                        </div>
                    </div>
                </div>
                <div class="col-sm-4 col-xs-12 profile" id="Product8Panel" runat="server">
                    <div class="panel panel-default">
                        <div class="panel-thumbnail">	
                            <a href="#" class="thumbnail" data-toggle="modal" data-target="#lightbox"> 
                                <img src="https://scontent-sea.xx.fbcdn.net/hphotos-xpf1/l/t31.0-8/10989198_1039271966087546_3311887831272768675_o.jpg" alt="...">
                            </a>

                        </div>
                        <div class="panel-body" align="center" style="height:250px;">
                            <p style="font-weight:bold">Pretzel Bites</p>
                            <p>Pretzels, caramel and Callebaut chocolate</p>
                            <p style="color:#00A300">$0.50 or 12/$5.00</p>
                            





                            <form target="paypal" action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
                            <input type="hidden" name="cmd" value="_s-xclick">
                            <input type="hidden" name="hosted_button_id" value="YNR7SQP7QYGP2">
                            <table>
                            <tr><td><input type="hidden" name="on0" value="How many?">How many?</td></tr><tr><td><select name="os0">
	                            <option value="1 for">1 for $0.50 CAD</option>
	                            <option value="12 for">12 for $5.00 CAD</option>
                            </select> </td></tr>
                            </table>
                            <input type="hidden" name="currency_code" value="CAD">
                            <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_cart_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
                            <img alt="" border="0" src="https://www.sandbox.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1">
                            </form>







                        </div>
                    </div>
                </div>
                <div class="col-sm-4 col-xs-12 profile" id="Product9Panel" runat="server">
                    <div class="panel panel-default">
                        <div class="panel-thumbnail">	

                            <a href="#" class="thumbnail" data-toggle="modal" data-target="#lightbox"> 
                                <img src="https://scontent-sea.xx.fbcdn.net/hphotos-xpf1/t31.0-8/11034396_1039272052754204_2433040483118841215_o.jpg" alt="...">
                            </a>

                        </div>
                        <div class="panel-body" align="center" style="height:250px;" >

                            <p style="font-weight:bold">Turtle Cups</p>
                            <p>Callebaut chocolate, pecans and caramel.</p>
                            <p style="color:#00A300">Small $2.50 or 12/$25.00</p>
                            <p style="color:#00A300">Large $4.50 or 12/$50.00</p>


                        

    

                            <form target="paypal" action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
                            <input type="hidden" name="cmd" value="_s-xclick">
                            <input type="hidden" name="hosted_button_id" value="VTTS89PCYYC7N">
                            <table>
                            <tr><td><input type="hidden" name="on0" value="Size and How many?">Size and How many?</td></tr><tr><td><select name="os0">
	                            <option value="1 Small for">1 Small for $2.50 CAD</option>
	                            <option value="12 Small for">12 Small for $25.00 CAD</option>
	                            <option value="1 Large for">1 Large for $4.50 CAD</option>
	                            <option value="12 Large for">12 Large for $50.00 CAD</option>
                            </select> </td></tr>
                            </table>
                            <input type="hidden" name="currency_code" value="CAD">
                            <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_cart_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
                            <img alt="" border="0" src="https://www.sandbox.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1">
                            </form>





                        </div>
                    </div>
                </div>
                <div class="col-sm-4 col-xs-12 profile" id="Product10Panel" runat="server">
                    <div class="panel panel-default">
                        <div class="panel-thumbnail">	

                            <a href="#" class="thumbnail" data-toggle="modal" data-target="#lightbox"> 
                                <img src="https://fbcdn-sphotos-b-a.akamaihd.net/hphotos-ak-xpf1/t31.0-8/10495712_1039271909420885_5253819773979455309_o.jpg" alt="...">
                            </a>

                        </div>
                        <div class="panel-body" align="center" style="height:250px;" >

                            <p style="font-weight:bold">Yum Yum – Blueberry</p>
                            <p>Graham cracker crumbs, butter, Philadelphia cream cheese, whipping cream, dream whip and blueberry pie filling</p>
                            <p style="color:#00A300">9” x 9” = $20.00</p>
                            <p style="color:#00A300">9” x 15” = $45.00</p>


                            <form target="paypal" action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
                            <input type="hidden" name="cmd" value="_s-xclick">
                            <input type="hidden" name="hosted_button_id" value="WMSCS9V857622">
                            <table>
                            <tr><td><input type="hidden" name="on0" value="What size?">What size?</td></tr><tr><td><select name="os0">
	                            <option value="9" x 9" for">9" x 9" for $20.00 CAD</option>
	                            <option value="9" x 15" for">9" x 15" for $45.00 CAD</option>
                            </select> </td></tr>
                            </table>
                            <input type="hidden" name="currency_code" value="CAD">
                            <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_cart_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
                            <img alt="" border="0" src="https://www.sandbox.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1">
                            </form>

                        </div>
                    </div>
                </div>
                <div class="col-sm-4 col-xs-12 profile" id="Product11Panel" runat="server">
                    <div class="panel panel-default">
                        <div class="panel-thumbnail">	

                            <a href="#" class="thumbnail" data-toggle="modal" data-target="#lightbox"> 
                                <img src="https://scontent-sea.xx.fbcdn.net/hphotos-xap1/t31.0-8/11043432_1039271906087552_5867880771729155617_o.jpg" alt="...">
                            </a>

                        </div>
                        <div class="panel-body" align="center" style="height:250px;">

                            <p style="font-weight:bold">Yum Yum - Cherry</p>
                            <p>Graham cracker crumbs, butter, Philadelphia cream cheese, whipping cream, dream whip and cherry pie filling</p>
                            <p style="color:#00A300">9” x 9” = $20.00</p>
                            <p style="color:#00A300">9” x 15” = $45.00</p>


                            <form target="paypal" action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
                            <input type="hidden" name="cmd" value="_s-xclick">
                            <input type="hidden" name="hosted_button_id" value="L8QNYBTRTP3W2">
                            <table>
                            <tr><td><input type="hidden" name="on0" value="What size?">What size?</td></tr><tr><td><select name="os0">
	                            <option value="9" x 9" for">9" x 9" for $20.00 CAD</option>
	                            <option value="9" x 15" for">9" x 15" for $45.00 CAD</option>
                            </select> </td></tr>
                            </table>
                            <input type="hidden" name="currency_code" value="CAD">
                            <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_cart_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
                            <img alt="" border="0" src="https://www.sandbox.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1">
                            </form>

                        </div>
                    </div>
                </div>
                <div class="col-sm-4 col-xs-12 profile" id="ProductTwelve" runat="server">
                    <div class="panel panel-default">
                        <div class="panel-thumbnail">	

                            <a href="#" class="thumbnail" data-toggle="modal" data-target="#lightbox"> 
                                <img src="https://fbcdn-sphotos-a-a.akamaihd.net/hphotos-ak-xpa1/t31.0-8/10991761_1039252639422812_3764020106044574844_o.jpg" alt="...">
                            </a>

                        </div>
                        <div class="panel-body" align="center" style="height:250px;" >

                            <p style="font-weight:bold">Yum Yum - Peach</p>
                            <p>Graham cracker crumbs, butter, Philadelphia cream cheese, whipping cream, dream whip and peach pie filling</p>
                            <p style="color:#00A300">9” x 9” = $20.00</p>
                            <p style="color:#00A300">9” x 15” = $45.00</p>


                            <form target="paypal" action="https://www.sandbox.paypal.com/cgi-bin/webscr" method="post">
                            <input type="hidden" name="cmd" value="_s-xclick">
                            <input type="hidden" name="hosted_button_id" value="X5XWK9WGP9GFS">
                            <table>
                            <tr><td><input type="hidden" name="on0" value="What size?">What size?</td></tr><tr><td><select name="os0">
	                            <option value="9" x 9" for">9" x 9" for $20.00 CAD</option>
	                            <option value="9" x 15" for">9" x 15" for $45.00 CAD</option>
                            </select> </td></tr>
                            </table>
                            <input type="hidden" name="currency_code" value="CAD">
                            <input type="image" src="https://www.sandbox.paypal.com/en_US/i/btn/btn_cart_LG.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
                            <img alt="" border="0" src="https://www.sandbox.paypal.com/en_US/i/scr/pixel.gif" width="1" height="1">
                            </form>

                        </div>
                    </div>
                </div>
            </div>

<!--End of Menu -->


         <div id="lightbox" class="modal fade" tabindex="-1" role="dialog" aria-labelledby="myLargeModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <button type="button" class="close hidden" data-dismiss="modal" aria-hidden="true">×</button>
        <div class="modal-content">
            <div class="modal-body">
                <img src="" alt="" />
            </div>
        </div>
    </div>
</div>










</asp:Content>
