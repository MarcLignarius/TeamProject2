#pragma checksum "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dd38168cd0dff74bb4318bca73e3237a2406da8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game3_Index), @"mvc.1.0.view", @"/Views/Game3/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Game3/Index.cshtml", typeof(AspNetCore.Views_Game3_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd38168cd0dff74bb4318bca73e3237a2406da8", @"/Views/Game3/Index.cshtml")]
    public class Views_Game3_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/gamestyles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 652, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd38168cd0dff74bb4318bca73e3237a2406da84732", async() => {
                BeginContext(29, 55, true);
                WriteLiteral("\n  <meta charset=\'utf-8\'>\n  <title>Game Site</title>\n  ");
                EndContext();
                BeginContext(84, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8dd38168cd0dff74bb4318bca73e3237a2406da85163", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(164, 374, true);
                WriteLiteral(@"
  <link rel=""stylesheet"" href=""css/lightGallery.css"" type=""text/css"" media=""all"" />
  <link href=""https://fonts.googleapis.com/css?family=Rubik&display=swap"" rel=""stylesheet"">
  <script defer src=""https://use.fontawesome.com/releases/v5.0.13/js/all.js"" integrity=""sha384-xymdQtn1n3lH2wcu0qhcdaOpQwyoarkgLVxC/wZ5q7h9gHtxICrpcaSUfygqZGOe"" crossorigin=""anonymous""></script>
  ");
                EndContext();
                BeginContext(538, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8dd38168cd0dff74bb4318bca73e3237a2406da87035", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(619, 49, true);
                WriteLiteral("\n  <link rel=\"stylesheet\" href=\"/css/xpbar.css\">\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(675, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(676, 5505, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd38168cd0dff74bb4318bca73e3237a2406da89352", async() => {
                BeginContext(682, 2351, true);
                WriteLiteral(@"
  <div class=""hero-image"">
    <div class=""hero-text"">
      <h1>Game Three</h1>
      <br>
      <button><a href=""/play3"">Play</a></button>
    </div>
  </div>
  <div class=""container"">
    <h3 class=""title"">About the game</h3>
    <p class=""subtitle"">Fight for your life</p>
    <br>
    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.<p>
    <br>
    <hr>
    <br>
    <h3 class=""title"">How to play</h3>
    <p class=""subtitle"">Master your sword</p>
    <br>
    <ul>
      <li><p>Use the <i class=""left""></i> and <i class=""right""></i> arrows to move left or right.</p></li>
      <li><p>Use the <i class=""up""></i> arr");
                WriteLiteral(@"ow to jump.</p></li>
      <li><p>Use the space key to attack.</p></li>
    </ul>
    <br>
    <hr>
    <br>
    <h3 class=""title"">Gallery</h3>
    <p class=""subtitle"">In game screenshots</p>
    <br>
    <div class=""gallery"">
      <div class=""grid-container"">
        <div class=""grid-item"">
           <img src=""../img/ss1.png"" alt=""game 1 image"">
        </div>
        <div class=""grid-item"">
           <img src=""../img/ss2.png"" alt=""game 1 image"">
        </div>
        <div class=""grid-item"">
           <img src=""../img/ss3.png"" alt=""game 1 image"">
        </div>
      </div>
      <div class=""grid-container"">
        <div class=""grid-item"">
           <img src=""../img/ss4.png"" alt=""game 1 image"">
        </div>
        <div class=""grid-item"">
           <img src=""../img/ss5.png"" alt=""game 1 image"">
        </div>
        <div class=""grid-item"">
           <img src=""../img/ss6.png"" alt=""game 1 image"">
        </div>
      </div>
      <div class=""grid-container"">
        <div class=""grid-item"">
          ");
                WriteLiteral(@" <img src=""../img/ss7.png"" alt=""game 1 image"">
        </div>
        <div class=""grid-item"">
           <img src=""../img/ss8.png"" alt=""game 1 image"">
        </div>
        <div class=""grid-item"">
           <img src=""../img/ss9.png"" alt=""game 1 image"">
        </div>
      </div>
    </div>
  </div>
");
                EndContext();
                BeginContext(3060, 1406, true);
                WriteLiteral(@"  <footer class=""gameindexfooter"">
    <div class=""grid-container"">
      <div class=""grid-item"">
        <h4 style=""text-align: left"">Epicodus Games</h4>
        <p>400 SW 6th Ave #800, Portland, OR 97204</p>
        <p>info@epicodusgames.com</p>
        <br>
      </div>
      <div class=""grid-item"">
        <ul class=""nav"" style=""text-align: center"">
          <button><a href=""/games"">Our Games</a></button>
          <button><a href=""/about"">About Us</a></button>
          <button><a href=""/contact"">Contact Us</a></button>
        </ul>
      </div>
      <div class=""grid-item"">
        <h4 style=""text-align: right "" class=""connect"">Connect with us:</h4>
        <div class=""rounded-social-buttons"">
          <a class=""social-button facebook"" href=""https://www.facebook.com/"" target=""_blank""><i class=""fab fa-facebook-f""></i></a>
          <a class=""social-button twitter"" href=""https://www.twitter.com/"" target=""_blank""><i class=""fab fa-twitter""></i></a>
          <a class=""social-button linkedin"" href=""https:");
                WriteLiteral(@"//www.linkedin.com/"" target=""_blank""><i class=""fab fa-linkedin""></i></a>
          <a class=""social-button youtube"" href=""https://www.youtube.com/"" target=""_blank""><i class=""fab fa-youtube""></i></a>
          <a class=""social-button instagram"" href=""https://www.instagram.com/"" target=""_blank""><i class=""fab fa-instagram""></i></a>
        </div>
      </div>
    </div>
  </footer>
");
                EndContext();
                BeginContext(4504, 93, true);
                WriteLiteral("  <div id=\'account-bar-wrapper\'>\n    <div id=\'account-bar\'>\n      <div id=\'account-bar-name\'>");
                EndContext();
                BeginContext(4598, 17, false);
#line 110 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
                            Write(Model.Accountname);

#line default
#line hidden
                EndContext();
                BeginContext(4615, 47, true);
                WriteLiteral("</div>\n      <div id=\'account-bar-level\'>Level ");
                EndContext();
                BeginContext(4663, 11, false);
#line 111 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
                                   Write(Model.Level);

#line default
#line hidden
                EndContext();
                BeginContext(4674, 31, true);
                WriteLiteral("</div>\n      <div id=\'xp-bar\'>\n");
                EndContext();
#line 113 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
          
          if(Model.LevelBar * 10 >= 10){

#line default
#line hidden
                BeginContext(4757, 43, true);
                WriteLiteral("            <div id=\'xp-bar-fill10\'></div>\n");
                EndContext();
#line 116 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
          }
          else if (Model.LevelBar * 10 >= 9){

#line default
#line hidden
                BeginContext(4858, 42, true);
                WriteLiteral("            <div id=\'xp-bar-fill9\'></div>\n");
                EndContext();
#line 119 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
          }
          else if (Model.LevelBar * 10 >= 8){

#line default
#line hidden
                BeginContext(4958, 42, true);
                WriteLiteral("            <div id=\'xp-bar-fill8\'></div>\n");
                EndContext();
#line 122 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
          }
          else if (Model.LevelBar * 10 >= 7){

#line default
#line hidden
                BeginContext(5058, 42, true);
                WriteLiteral("            <div id=\'xp-bar-fill7\'></div>\n");
                EndContext();
#line 125 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
          }
          else if (Model.LevelBar * 10 >= 6){

#line default
#line hidden
                BeginContext(5158, 42, true);
                WriteLiteral("            <div id=\'xp-bar-fill6\'></div>\n");
                EndContext();
#line 128 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
          }
          else if (Model.LevelBar * 10 >= 5){

#line default
#line hidden
                BeginContext(5258, 42, true);
                WriteLiteral("            <div id=\'xp-bar-fill5\'></div>\n");
                EndContext();
#line 131 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
          }
          else if (Model.LevelBar * 10 >= 4){

#line default
#line hidden
                BeginContext(5358, 42, true);
                WriteLiteral("            <div id=\'xp-bar-fill4\'></div>\n");
                EndContext();
#line 134 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
          }
          else if (Model.LevelBar * 10 >= 3){

#line default
#line hidden
                BeginContext(5458, 42, true);
                WriteLiteral("            <div id=\'xp-bar-fill3\'></div>\n");
                EndContext();
#line 137 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
          }
          else if (Model.LevelBar * 10 >= 2){

#line default
#line hidden
                BeginContext(5558, 42, true);
                WriteLiteral("            <div id=\'xp-bar-fill2\'></div>\n");
                EndContext();
#line 140 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
            }else if (Model.LevelBar * 10 >= 1){

#line default
#line hidden
                BeginContext(5649, 44, true);
                WriteLiteral("              <div id=\'xp-bar-fill1\'></div>\n");
                EndContext();
#line 142 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
            }
            else{

#line default
#line hidden
                BeginContext(5725, 44, true);
                WriteLiteral("              <div id=\'xp-bar-fill0\'></div>\n");
                EndContext();
#line 145 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
            }
          

#line default
#line hidden
                BeginContext(5795, 10, true);
                WriteLiteral("          ");
                EndContext();
                BeginContext(5840, 291, true);
                WriteLiteral(@"
          <div id='xp-increase-fx'><div id='xp-increase-fx-flicker'><div class='xp-increase-glow1'></div><div class='xp-increase-glow2'></div><div class='xp-increase-glow3'></div></div><div class='xp-increase-glow2'></div>
        </div>
      </div>
      <div id='account-bar-next-level'>");
                EndContext();
                BeginContext(6132, 15, false);
#line 151 "/Users/Guest/Desktop/TeamProject2/Views/Game3/Index.cshtml"
                                  Write(Model.NextLevel);

#line default
#line hidden
                EndContext();
                BeginContext(6147, 27, true);
                WriteLiteral("</div>\n    </div>\n  </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6181, 9, true);
            WriteLiteral("\n</html>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
