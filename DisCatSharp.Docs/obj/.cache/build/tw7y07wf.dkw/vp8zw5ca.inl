<!DOCTYPE html>
<!--[if IE]><![endif]-->
<html>
    
    <head>
      <meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
      <title>
    Namespace DisCatSharp.CommandsNext.Converters
    
    
    
    
    
    
    
    
    
    
    
    
    
    
     | DisCatSharp Docs </title>
      <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no">
      <meta name="title" content="
    Namespace DisCatSharp.CommandsNext.Converters
    
    
    
    
    
    
    
    
    
    
    
    
    
    
     | DisCatSharp Docs ">
      <meta name="og:title" content="
    Namespace DisCatSharp.CommandsNext.Converters
    
    
    
    
    
    
    
    
    
    
    
    
    
    
     | DisCatSharp Docs ">
      <meta name="generator" content="docfx 2.60.1.0">
      
    <meta name="og:type" content="website">
    <meta name="og:image" content="https://cdn.aitsys.dev/file/data/kmjpa6f64me66dsm7dz3/PHID-FILE-degpfzd7nbw2q5yko5j7/logobig.png">
    <meta name="og:image:alt" content="DisCatSharp Logo">
    <meta name="og:image:type" content="image/png">
    <meta name="og:site_name" content="DisCatSharp Documentation">
    <link rel="apple-touch-icon" sizes="57x57" href="../../apple-icon-57x57.png">
    <link rel="apple-touch-icon" sizes="60x60" href="../../apple-icon-60x60.png">
    <link rel="apple-touch-icon" sizes="72x72" href="../../apple-icon-72x72.png">
    <link rel="apple-touch-icon" sizes="76x76" href="../../apple-icon-76x76.png">
    <link rel="apple-touch-icon" sizes="114x114" href="../../apple-icon-114x114.png">
    <link rel="apple-touch-icon" sizes="120x120" href="../../apple-icon-120x120.png">
    <link rel="apple-touch-icon" sizes="144x144" href="../../apple-icon-144x144.png">
    <link rel="apple-touch-icon" sizes="152x152" href="../../apple-icon-152x152.png">
    <link rel="apple-touch-icon" sizes="180x180" href="../../apple-icon-180x180.png">
    <link rel="icon" type="image/png" sizes="192x192" href="../../android-icon-192x192.png">
    <link rel="icon" type="image/png" sizes="32x32" href="../../favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="96x96" href="../../favicon-96x96.png">
    <link rel="icon" type="image/png" sizes="16x16" href="../../favicon-16x16.png">
    <link rel="manifest" href="/manifest.json">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="msapplication-TileImage" content="../../ms-icon-144x144.png">
    <meta name="theme-color" content="#ffffff">
      <link rel="shortcut icon" href="../../favicon.ico">
      <script defer="" src='https://static.cloudflareinsights.com/beacon.min.js' data-cf-beacon='{"token": "de6c22ce0b3e4c17bb78c8c31b4e695b"}'></script>
      <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;500;700&display=swap" rel="stylesheet">
      <link rel="stylesheet" href="//cdnjs.cloudflare.com/ajax/libs/highlight.js/11.7.0/styles/night-owl.min.css">
      <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.7.2/font/bootstrap-icons.css" integrity="sha384-EvBWSlnoFgZlXJvpzS+MAUEjvN7+gcCwH+qh7GRFOGgZO0PuwOFro7qPOJnLfe7l" crossorigin="anonymous">
      <link rel="stylesheet" href="../../src/styles/config.css">
      <link rel="stylesheet" href="../../src/styles/discord.css">
      <link rel="stylesheet" href="../../src/styles/dcs.css">
      <link rel="stylesheet" href="../../src/styles/main.css">
      <link rel="stylesheet" href="../../src/styles/colors.css">
      <link rel="stylesheet" href="../../src/styles/highlight/github-dark.min.css">
      <meta property="docfx:navrel" content="../../toc.html">
      <meta property="docfx:tocrel" content="toc.html">
      
      <meta property="docfx:rel" content="../../">
      <meta property="docfx:newtab" content="true">
    </head>

    <body>
        <div class="top-navbar">
            <a class="burger-icon" onclick="toggleMenu()">
                <svg name="Hamburger" style="vertical-align: middle;" width="34" height="34" viewbox="0 0 24 24"><path fill="currentColor" fill-rule="evenodd" clip-rule="evenodd" d="M20 6H4V9H20V6ZM4 10.999H20V13.999H4V10.999ZM4 15.999H20V18.999H4V15.999Z"></path></svg>
            </a>

            
            <a class="navbar-brand" href="../../index.html">
              <img id="logo" class="svg" src="../../logo.png" alt="DisCatSharp">
            </a>
        </div>

        <div class="body-content">
            <div id="blackout" class="blackout" onclick="toggleMenu()"></div>

            <nav id="sidebar" role="navigation">
                <div class="sidebar">
                    
                    <div>
                      <div class="mobile-hide">
                        
                        <a class="navbar-brand" href="../../index.html">
                          <img id="logo" class="svg" src="../../logo.png" alt="DisCatSharp">
                        </a>
                      </div>

                      <div class="sidesearch">
                        <form id="search" role="search" class="search">
                            <i class="bi bi-search search-icon"></i>
                            <input type="text" id="search-query" placeholder="Search" autocomplete="off">
                        </form>
                      </div>
                    
                      <div id="navbar">
                      </div>
                    </div>
                    <div class="sidebar-item-separator"></div>
                        
                        <div id="sidetoggle">
                          <div id="sidetoc"></div>
                        </div>
                </div>
                <div class="footer">
                  <strong>Made with ♥ by AITSYS</strong>
                  
                </div>
            </nav>

            <main class="main-panel">
                
                <div id="search-results" style="display: none;">
                  <h1 class="search-list">Search Results for <span></span></h1>
                  <div class="sr-items">
                    <p class="lsearch"><i class="bi bi-hourglass-split index-loading"></i></p>
                  </div>
                  <ul id="pagination" data-first="First" data-prev="Previous" data-next="Next" data-last="Last"></ul>
                </div>

                <div role="main" class="hide-when-search">
                        
                        <div class="subnav navbar navbar-default">
                          <div class="container hide-when-search" id="breadcrumb">
                            <ul class="breadcrumb">
                              <li></li>
                            </ul>
                          </div>
                        </div>
						
						<div id="sidetoggle">
						  <div id="sidetoc"></div>
						</div>
						<div class="article row grid-right">

                    <article class="content wrap" id="_content" data-uid="DisCatSharp.CommandsNext.Converters">
  
  <h1 id="DisCatSharp_CommandsNext_Converters" data-uid="DisCatSharp.CommandsNext.Converters" class="text-break">
  Namespace DisCatSharp.CommandsNext.Converters
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  </h1>
  <div class="markdown level0 summary"></div>
  <div class="markdown level0 conceptual"></div>
  <div class="markdown level0 remarks"></div>
    <h3 id="classes">Classes
  </h3>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.BaseHelpFormatter.html">BaseHelpFormatter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.BaseHelpFormatter.yml" sourcestartlinenumber="2">Represents a base class for all default help formatters.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.BoolConverter.html">BoolConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.BoolConverter.yml" sourcestartlinenumber="2">The bool converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.DateTimeConverter.html">DateTimeConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.DateTimeConverter.yml" sourcestartlinenumber="2">Represents a date time converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.DateTimeOffsetConverter.html">DateTimeOffsetConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.DateTimeOffsetConverter.yml" sourcestartlinenumber="2">Represents a date time offset converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.DefaultHelpFormatter.html">DefaultHelpFormatter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.DefaultHelpFormatter.yml" sourcestartlinenumber="2">Default CommandsNext help formatter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.DiscordChannelConverter.html">DiscordChannelConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.DiscordChannelConverter.yml" sourcestartlinenumber="2">Represents a discord channel converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.DiscordColorConverter.html">DiscordColorConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.DiscordColorConverter.yml" sourcestartlinenumber="2">Represents a discord color converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.DiscordEmojiConverter.html">DiscordEmojiConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.DiscordEmojiConverter.yml" sourcestartlinenumber="2">Represents a discord emoji converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.DiscordGuildConverter.html">DiscordGuildConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.DiscordGuildConverter.yml" sourcestartlinenumber="2">Represents a discord guild converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.DiscordInviteConverter.html">DiscordInviteConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.DiscordInviteConverter.yml" sourcestartlinenumber="2">Represents a discord invite converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.DiscordMemberConverter.html">DiscordMemberConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.DiscordMemberConverter.yml" sourcestartlinenumber="2">Represents a discord member converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.DiscordMessageConverter.html">DiscordMessageConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.DiscordMessageConverter.yml" sourcestartlinenumber="2">Represents a discord message converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.DiscordRoleConverter.html">DiscordRoleConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.DiscordRoleConverter.yml" sourcestartlinenumber="2">Represents a discord role converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.DiscordScheduledEventConverter.html">DiscordScheduledEventConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.DiscordScheduledEventConverter.yml" sourcestartlinenumber="2">Represents a discord scheduled event converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.DiscordThreadChannelConverter.html">DiscordThreadChannelConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.DiscordThreadChannelConverter.yml" sourcestartlinenumber="2">Represents a discord thread channel converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.DiscordUserConverter.html">DiscordUserConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.DiscordUserConverter.yml" sourcestartlinenumber="2">Represents a discord user converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.EnumConverter-1.html">EnumConverter&lt;T&gt;</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.EnumConverter-1.yml" sourcestartlinenumber="2">Represents a enum converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.Float128Converter.html">Float128Converter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.Float128Converter.yml" sourcestartlinenumber="2">The float128 converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.Float32Converter.html">Float32Converter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.Float32Converter.yml" sourcestartlinenumber="2">The float32 converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.Float64Converter.html">Float64Converter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.Float64Converter.yml" sourcestartlinenumber="2">The float64 converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.Int16Converter.html">Int16Converter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.Int16Converter.yml" sourcestartlinenumber="2">The int16 converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.Int32Converter.html">Int32Converter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.Int32Converter.yml" sourcestartlinenumber="2">The int32 converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.Int64Converter.html">Int64Converter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.Int64Converter.yml" sourcestartlinenumber="2">The int64 converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.Int8Converter.html">Int8Converter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.Int8Converter.yml" sourcestartlinenumber="2">The int8 converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.NullableConverter-1.html">NullableConverter&lt;T&gt;</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.NullableConverter-1.yml" sourcestartlinenumber="2">Represents a nullable converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.StringConverter.html">StringConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.StringConverter.yml" sourcestartlinenumber="2">Represents a string converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.TimeSpanConverter.html">TimeSpanConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.TimeSpanConverter.yml" sourcestartlinenumber="2">Represents a time span converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.Uint16Converter.html">Uint16Converter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.Uint16Converter.yml" sourcestartlinenumber="2">The uint16 converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.Uint32Converter.html">Uint32Converter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.Uint32Converter.yml" sourcestartlinenumber="2">The uint32 converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.Uint64Converter.html">Uint64Converter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.Uint64Converter.yml" sourcestartlinenumber="2">The uint64 converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.Uint8Converter.html">Uint8Converter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.Uint8Converter.yml" sourcestartlinenumber="2">The uint8 converter.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.UriConverter.html">UriConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.UriConverter.yml" sourcestartlinenumber="2">Represents a uri converter.</p>
</section>
    <h3 id="structs">Structs
  </h3>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.ArgumentBindingResult.html">ArgumentBindingResult</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.ArgumentBindingResult.yml" sourcestartlinenumber="2">Represents a argument binding result.</p>
</section>
    <h3 id="interfaces">Interfaces
  </h3>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.IArgumentConverter.html">IArgumentConverter</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.IArgumentConverter.yml" sourcestartlinenumber="2">Argument converter abstract.</p>
</section>
      <h5><a class="xref" href="DisCatSharp.CommandsNext.Converters.IArgumentConverter-1.html">IArgumentConverter&lt;T&gt;</a></h5>
      <section><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.Converters.IArgumentConverter-1.yml" sourcestartlinenumber="2">Represents a converter for specific argument type.</p>
</section>

</article>
                </div>

                <div class="copyright-footer">
                    <span>&#169; Aiko IT Systems. All rights reserved.</span>
                </div>
            </div></main>
        

        
        <script src="https://code.jquery.com/jquery-3.5.1.min.js" integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=" crossorigin="anonymous"></script>
        <script type="text/javascript" src="../../src/scripts/docfx.vendor.js"></script>
        <script type="text/javascript" src="../../src/scripts/docfx.js"></script>
        <script type="text/javascript" src="../../src/scripts/url.min.js"></script>
        <script type="text/javascript" src="../../src/scripts/highlight/highlight.min.js"></script>
        <script>hljs.highlightAll();</script>
        <script src="https://cdn.jsdelivr.net/npm/anchor-js/anchor.min.js"></script>
        <script type="text/javascript" src="../../src/scripts/jquery.twbsPagination.js"></script>
        <script type="text/javascript" src="../../src/scripts/dcs.js"></script>
        <script type="text/javascript" src="../../src/scripts/lunr.js"></script>
    </div></body>
</html>