<!DOCTYPE html>
<!--[if IE]><![endif]-->
<html>

    <head>
      <meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
      <title>Class CommandsNextExtension
 | DisCatSharp Docs </title>
      <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no">
      <meta name="generator" content="docfx 2.60.0.0">
  
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

                    <article class="content wrap" id="_content" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension">


  <h1 id="DisCatSharp_CommandsNext_CommandsNextExtension" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension" class="text-break">Class CommandsNextExtension
</h1>
  <div class="markdown level0 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">This is the class which handles command registration, management, and execution.</p>
</div>
  <div class="markdown level0 conceptual"></div>
  <div class="inheritance">
    <h5>Inheritance</h5>
    <div class="level0"><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.object">Object</a></div>
    <div class="level1"><a class="xref" href="../DisCatSharp/DisCatSharp.BaseExtension.html">BaseExtension</a></div>
    <div class="level2"><span class="xref">CommandsNextExtension</span></div>
  </div>
  <div class="inheritedMembers">
    <h5>Inherited Members</h5>
    <div>
      <a class="xref" href="../DisCatSharp/DisCatSharp.BaseExtension.html#DisCatSharp_BaseExtension_Client">BaseExtension.Client</a>
    </div>
  </div>
  <h6><strong>Namespace</strong>: <a class="xref" href="DisCatSharp.CommandsNext.html">DisCatSharp.CommandsNext</a></h6>
  <h6><strong>Assembly</strong>: DisCatSharp.CommandsNext.dll</h6>
  <h5 id="DisCatSharp_CommandsNext_CommandsNextExtension_syntax">Syntax</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public class CommandsNextExtension : BaseExtension</code></pre>
  </div>
  <h3 id="properties">Properties
</h3>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_RegisteredCommands.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.RegisteredCommands%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L419">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_RegisteredCommands_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.RegisteredCommands*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_RegisteredCommands" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.RegisteredCommands">RegisteredCommands</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Gets a dictionary of registered top-level commands.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public IReadOnlyDictionary&lt;string, Command&gt; RegisteredCommands { get; }</code></pre>
  </div>
  <h5 class="propertyValue">Property Value</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">IReadOnlyDictionary</span>&lt;<a class="xref" href="https://learn.microsoft.com/dotnet/api/system.string">String</a>, <a class="xref" href="DisCatSharp.CommandsNext.Command.html">Command</a>&gt;</td>
        <td></td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_Services.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.Services%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L76">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_Services_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.Services*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_Services" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.Services">Services</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Gets the service provider this CommandsNext module was configured with.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public IServiceProvider Services { get; }</code></pre>
  </div>
  <h5 class="propertyValue">Property Value</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">IServiceProvider</span></td>
        <td></td>
      </tr>
    </tbody>
  </table>
  <h3 id="methods">Methods
</h3>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_ConvertArgument_System_String_DisCatSharp_CommandsNext_CommandContext_Type_.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.ConvertArgument(System.String%2CDisCatSharp.CommandsNext.CommandContext%2CType)%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L923">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_ConvertArgument_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.ConvertArgument*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_ConvertArgument_System_String_DisCatSharp_CommandsNext_CommandContext_Type_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.ConvertArgument(System.String,DisCatSharp.CommandsNext.CommandContext,Type)">ConvertArgument(String, CommandContext, Type)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Converts a string to specified type.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public async Task&lt;object&gt; ConvertArgument(string value, CommandContext ctx, Type type)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.string">String</a></td>
        <td><span class="parametername">value</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Value to convert.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="DisCatSharp.CommandsNext.CommandContext.html">CommandContext</a></td>
        <td><span class="parametername">ctx</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Context in which to convert to.</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">Type</span></td>
        <td><span class="parametername">type</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Type to convert to.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">Task</span>&lt;<a class="xref" href="https://learn.microsoft.com/dotnet/api/system.object">Object</a>&gt;</td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Converted object.</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_ConvertArgument__1_System_String_DisCatSharp_CommandsNext_CommandContext_.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.ConvertArgument%60%601(System.String%2CDisCatSharp.CommandsNext.CommandContext)%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L903">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_ConvertArgument_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.ConvertArgument*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_ConvertArgument__1_System_String_DisCatSharp_CommandsNext_CommandContext_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.ConvertArgument``1(System.String,DisCatSharp.CommandsNext.CommandContext)">ConvertArgument&lt;T&gt;(String, CommandContext)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Converts a string to specified type.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public async Task&lt;T&gt; ConvertArgument&lt;T&gt;(string value, CommandContext ctx)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.string">String</a></td>
        <td><span class="parametername">value</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Value to convert.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="DisCatSharp.CommandsNext.CommandContext.html">CommandContext</a></td>
        <td><span class="parametername">ctx</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Context in which to convert to.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">Task</span>&lt;T&gt;</td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Converted object.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="typeParameters">Type Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="parametername">T</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Type to convert to.</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_CreateContext_DisCatSharp_Entities_DiscordMessage_System_String_DisCatSharp_CommandsNext_Command_System_String_.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.CreateContext(DisCatSharp.Entities.DiscordMessage%2CSystem.String%2CDisCatSharp.CommandsNext.Command%2CSystem.String)%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L344">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_CreateContext_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.CreateContext*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_CreateContext_DisCatSharp_Entities_DiscordMessage_System_String_DisCatSharp_CommandsNext_Command_System_String_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.CreateContext(DisCatSharp.Entities.DiscordMessage,System.String,DisCatSharp.CommandsNext.Command,System.String)">CreateContext(DiscordMessage, String, Command, String)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Creates a command execution context from specified arguments.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public CommandContext CreateContext(DiscordMessage msg, string prefix, Command cmd, string rawArguments = null)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="../DisCatSharp/DisCatSharp.Entities.DiscordMessage.html">DiscordMessage</a></td>
        <td><span class="parametername">msg</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Message to use for context.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.string">String</a></td>
        <td><span class="parametername">prefix</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Command prefix, used to execute commands.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="DisCatSharp.CommandsNext.Command.html">Command</a></td>
        <td><span class="parametername">cmd</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Command to execute.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.string">String</a></td>
        <td><span class="parametername">rawArguments</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Raw arguments to pass to command.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="DisCatSharp.CommandsNext.CommandContext.html">CommandContext</a></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Created command execution context.</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_CreateFakeContext_DisCatSharp_Entities_DiscordUser_DisCatSharp_Entities_DiscordChannel_System_String_System_String_DisCatSharp_CommandsNext_Command_System_String_.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.CreateFakeContext(DisCatSharp.Entities.DiscordUser%2CDisCatSharp.Entities.DiscordChannel%2CSystem.String%2CSystem.String%2CDisCatSharp.CommandsNext.Command%2CSystem.String)%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L827">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_CreateFakeContext_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.CreateFakeContext*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_CreateFakeContext_DisCatSharp_Entities_DiscordUser_DisCatSharp_Entities_DiscordChannel_System_String_System_String_DisCatSharp_CommandsNext_Command_System_String_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.CreateFakeContext(DisCatSharp.Entities.DiscordUser,DisCatSharp.Entities.DiscordChannel,System.String,System.String,DisCatSharp.CommandsNext.Command,System.String)">CreateFakeContext(DiscordUser, DiscordChannel, String, String, Command, String)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Creates a fake command context to execute commands with.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public CommandContext CreateFakeContext(DiscordUser actor, DiscordChannel channel, string messageContents, string prefix, Command cmd, string rawArguments = null)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="../DisCatSharp/DisCatSharp.Entities.DiscordUser.html">DiscordUser</a></td>
        <td><span class="parametername">actor</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">The user or member to use as message author.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="../DisCatSharp/DisCatSharp.Entities.DiscordChannel.html">DiscordChannel</a></td>
        <td><span class="parametername">channel</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">The channel the message is supposed to appear from.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.string">String</a></td>
        <td><span class="parametername">messageContents</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Contents of the message.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.string">String</a></td>
        <td><span class="parametername">prefix</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Command prefix, used to execute commands.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="DisCatSharp.CommandsNext.Command.html">Command</a></td>
        <td><span class="parametername">cmd</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Command to execute.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.string">String</a></td>
        <td><span class="parametername">rawArguments</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Raw arguments to pass to command.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="DisCatSharp.CommandsNext.CommandContext.html">CommandContext</a></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Created fake context.</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_ExecuteCommandAsync_DisCatSharp_CommandsNext_CommandContext_.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.ExecuteCommandAsync(DisCatSharp.CommandsNext.CommandContext)%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L373">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_ExecuteCommandAsync_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.ExecuteCommandAsync*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_ExecuteCommandAsync_DisCatSharp_CommandsNext_CommandContext_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.ExecuteCommandAsync(DisCatSharp.CommandsNext.CommandContext)">ExecuteCommandAsync(CommandContext)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Executes specified command from given context.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public async Task ExecuteCommandAsync(CommandContext ctx)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="DisCatSharp.CommandsNext.CommandContext.html">CommandContext</a></td>
        <td><span class="parametername">ctx</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Context to execute command from.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">Task</span></td>
        <td></td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_FindCommand_System_String_System_String__.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.FindCommand(System.String%2CSystem.String%40)%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L277">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_FindCommand_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.FindCommand*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_FindCommand_System_String_System_String__" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.FindCommand(System.String,System.String@)">FindCommand(String, out String)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Finds a specified command by its qualified name, then separates arguments.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public Command FindCommand(string commandString, out string rawArguments)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.string">String</a></td>
        <td><span class="parametername">commandString</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Qualified name of the command, optionally with arguments.</p>
</td>
      </tr>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.string">String</a></td>
        <td><span class="parametername">rawArguments</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Separated arguments.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="DisCatSharp.CommandsNext.Command.html">Command</a></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Found command or null if none was found.</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_GetUserFriendlyTypeName_Type_.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.GetUserFriendlyTypeName(Type)%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L1016">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_GetUserFriendlyTypeName_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.GetUserFriendlyTypeName*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_GetUserFriendlyTypeName_Type_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.GetUserFriendlyTypeName(Type)">GetUserFriendlyTypeName(Type)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Converts a type into user-friendly type name.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public string GetUserFriendlyTypeName(Type t)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">Type</span></td>
        <td><span class="parametername">t</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Type to convert.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.string">String</a></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">User-friendly type name.</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_RegisterCommands_Assembly_.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.RegisterCommands(Assembly)%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L432">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_RegisterCommands_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.RegisterCommands*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_RegisterCommands_Assembly_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.RegisterCommands(Assembly)">RegisterCommands(Assembly)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Registers all commands from a given assembly. The command classes need to be public to be considered for registration.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public void RegisterCommands(Assembly assembly)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">Assembly</span></td>
        <td><span class="parametername">assembly</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Assembly to register commands from.</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_RegisterCommands_DisCatSharp_CommandsNext_Builders_CommandBuilder___.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.RegisterCommands(DisCatSharp.CommandsNext.Builders.CommandBuilder%5B%5D)%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L672">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_RegisterCommands_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.RegisterCommands*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_RegisterCommands_DisCatSharp_CommandsNext_Builders_CommandBuilder___" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.RegisterCommands(DisCatSharp.CommandsNext.Builders.CommandBuilder[])">RegisterCommands(CommandBuilder[])</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Builds and registers all supplied commands.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public void RegisterCommands(params CommandBuilder[] cmds)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="DisCatSharp.CommandsNext.Builders.CommandBuilder.html">CommandBuilder</a>[]</td>
        <td><span class="parametername">cmds</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Commands to build and register.</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_RegisterCommands_Type_.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.RegisterCommands(Type)%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L457">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_RegisterCommands_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.RegisterCommands*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_RegisterCommands_Type_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.RegisterCommands(Type)">RegisterCommands(Type)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Registers all commands from a given command class.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public void RegisterCommands(Type t)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">Type</span></td>
        <td><span class="parametername">t</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Type of the class which holds commands to register.</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_RegisterCommands__1.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.RegisterCommands%60%601%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L447">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_RegisterCommands_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.RegisterCommands*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_RegisterCommands__1" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.RegisterCommands``1">RegisterCommands&lt;T&gt;()</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Registers all commands from a given command class.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public void RegisterCommands&lt;T&gt;()
    where T : BaseCommandModule</code></pre>
  </div>
  <h5 class="typeParameters">Type Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="parametername">T</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Class which holds commands to register.</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_RegisterConverter__1_DisCatSharp_CommandsNext_Converters_IArgumentConverter___0__.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.RegisterConverter%60%601(DisCatSharp.CommandsNext.Converters.IArgumentConverter%7B%60%600%7D)%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L941">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_RegisterConverter_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.RegisterConverter*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_RegisterConverter__1_DisCatSharp_CommandsNext_Converters_IArgumentConverter___0__" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.RegisterConverter``1(DisCatSharp.CommandsNext.Converters.IArgumentConverter{``0})">RegisterConverter&lt;T&gt;(IArgumentConverter&lt;T&gt;)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Registers an argument converter for specified type.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public void RegisterConverter&lt;T&gt;(IArgumentConverter&lt;T&gt; converter)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="DisCatSharp.CommandsNext.Converters.IArgumentConverter-1.html">IArgumentConverter</a>&lt;T&gt;</td>
        <td><span class="parametername">converter</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Converter to register.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="typeParameters">Type Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="parametername">T</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Type for which to register the converter.</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_RegisterUserFriendlyTypeName__1_System_String_.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.RegisterUserFriendlyTypeName%60%601(System.String)%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L992">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_RegisterUserFriendlyTypeName_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.RegisterUserFriendlyTypeName*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_RegisterUserFriendlyTypeName__1_System_String_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.RegisterUserFriendlyTypeName``1(System.String)">RegisterUserFriendlyTypeName&lt;T&gt;(String)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Registers a user-friendly type name.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public void RegisterUserFriendlyTypeName&lt;T&gt;(string value)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="https://learn.microsoft.com/dotnet/api/system.string">String</a></td>
        <td><span class="parametername">value</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Name to register.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="typeParameters">Type Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="parametername">T</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Type to register the name for.</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_SetHelpFormatter__1.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.SetHelpFormatter%60%601%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L181">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_SetHelpFormatter_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.SetHelpFormatter*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_SetHelpFormatter__1" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.SetHelpFormatter``1">SetHelpFormatter&lt;T&gt;()</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Sets the help formatter to use with the default help command.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public void SetHelpFormatter&lt;T&gt;()
    where T : BaseHelpFormatter</code></pre>
  </div>
  <h5 class="typeParameters">Type Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="parametername">T</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Type of the formatter to use.</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_Setup_DisCatSharp_DiscordClient_.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.Setup(DisCatSharp.DiscordClient)%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L189">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_Setup_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.Setup*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_Setup_DisCatSharp_DiscordClient_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.Setup(DisCatSharp.DiscordClient)">Setup(DiscordClient)</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">DO NOT USE THIS MANUALLY.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">protected override void Setup(DiscordClient client)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="../DisCatSharp/DisCatSharp.DiscordClient.html">DiscordClient</a></td>
        <td><span class="parametername">client</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">DO NOT USE THIS MANUALLY.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="overrides">Overrides</h5>
  <div><a class="xref" href="../DisCatSharp/DisCatSharp.BaseExtension.html#DisCatSharp_BaseExtension_Setup_DisCatSharp_DiscordClient_">BaseExtension.Setup(DiscordClient)</a></div>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_UnregisterCommands_DisCatSharp_CommandsNext_Command___.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.UnregisterCommands(DisCatSharp.CommandsNext.Command%5B%5D)%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L682">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_UnregisterCommands_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.UnregisterCommands*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_UnregisterCommands_DisCatSharp_CommandsNext_Command___" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.UnregisterCommands(DisCatSharp.CommandsNext.Command[])">UnregisterCommands(Command[])</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Unregister specified commands from CommandsNext.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public void UnregisterCommands(params Command[] cmds)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="DisCatSharp.CommandsNext.Command.html">Command</a>[]</td>
        <td><span class="parametername">cmds</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Commands to unregister.</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_UnregisterConverter__1.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.UnregisterConverter%60%601%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L966">View Source</a>
  </span>
  <a id="DisCatSharp_CommandsNext_CommandsNextExtension_UnregisterConverter_" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.UnregisterConverter*"></a>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_UnregisterConverter__1" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.UnregisterConverter``1">UnregisterConverter&lt;T&gt;()</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Unregister an argument converter for specified type.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public void UnregisterConverter&lt;T&gt;()</code></pre>
  </div>
  <h5 class="typeParameters">Type Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="parametername">T</span></td>
        <td><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="1" sourceendlinenumber="1">Type for which to unregister the converter.</p>
</td>
      </tr>
    </tbody>
  </table>
  <h3 id="events">Events
</h3>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_CommandErrored.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.CommandErrored%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L1065">View Source</a>
  </span>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_CommandErrored" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.CommandErrored">CommandErrored</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Triggered whenever a command throws an exception during execution.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public event AsyncEventHandler&lt;CommandsNextExtension, CommandErrorEventArgs&gt; CommandErrored</code></pre>
  </div>
  <h5 class="eventType">Event Type</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="../DisCatSharp.Common/DisCatSharp.Common.Utilities.AsyncEventHandler-2.html">AsyncEventHandler</a>&lt;<a class="xref" href="DisCatSharp.CommandsNext.CommandsNextExtension.html">CommandsNextExtension</a>, <a class="xref" href="DisCatSharp.CommandsNext.CommandErrorEventArgs.html">CommandErrorEventArgs</a>&gt;</td>
        <td></td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/new/main/apiSpec/new?filename=DisCatSharp_CommandsNext_CommandsNextExtension_CommandExecuted.md&amp;value=---%0Auid%3A%20DisCatSharp.CommandsNext.CommandsNextExtension.CommandExecuted%0Asummary%3A%20&#39;*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax&#39;%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/Aiko-IT-Systems/DisCatSharp/blob/main/DisCatSharp.CommandsNext/CommandsNextExtension.cs/#L1055">View Source</a>
  </span>
  <h4 id="DisCatSharp_CommandsNext_CommandsNextExtension_CommandExecuted" data-uid="DisCatSharp.CommandsNext.CommandsNextExtension.CommandExecuted">CommandExecuted</h4>
  <div class="markdown level1 summary"><p sourcefile="api/DisCatSharp.CommandsNext/DisCatSharp.CommandsNext.CommandsNextExtension.yml" sourcestartlinenumber="2" sourceendlinenumber="2">Triggered whenever a command executes successfully.</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public event AsyncEventHandler&lt;CommandsNextExtension, CommandExecutionEventArgs&gt; CommandExecuted</code></pre>
  </div>
  <h5 class="eventType">Event Type</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><a class="xref" href="../DisCatSharp.Common/DisCatSharp.Common.Utilities.AsyncEventHandler-2.html">AsyncEventHandler</a>&lt;<a class="xref" href="DisCatSharp.CommandsNext.CommandsNextExtension.html">CommandsNextExtension</a>, <a class="xref" href="DisCatSharp.CommandsNext.CommandExecutionEventArgs.html">CommandExecutionEventArgs</a>&gt;</td>
        <td></td>
      </tr>
    </tbody>
  </table>

</article>
                </div>

                <div class="copyright-footer">
                    <span>&#169; Aiko IT Systems. All rights reserved.</span>
                </div>
            </div></main>
        </div>


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
    </body>
</html>