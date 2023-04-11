<!DOCTYPE html>
<!--[if IE]><![endif]-->
<html>

    <head>
      <meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
      <title>Select Menus | DisCatSharp Docs </title>
      <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no">
      <meta name="generator" content="docfx 2.60.0.0">
  
    <meta name="og:type" content="website">
    <meta name="og:image" content="https://cdn.aitsys.dev/file/data/kmjpa6f64me66dsm7dz3/PHID-FILE-degpfzd7nbw2q5yko5j7/logobig.png">
    <meta name="og:image:alt" content="DisCatSharp Logo">
    <meta name="og:image:type" content="image/png">
    <meta name="og:site_name" content="DisCatSharp Documentation">
    <link rel="apple-touch-icon" sizes="57x57" href="../../../apple-icon-57x57.png">
    <link rel="apple-touch-icon" sizes="60x60" href="../../../apple-icon-60x60.png">
    <link rel="apple-touch-icon" sizes="72x72" href="../../../apple-icon-72x72.png">
    <link rel="apple-touch-icon" sizes="76x76" href="../../../apple-icon-76x76.png">
    <link rel="apple-touch-icon" sizes="114x114" href="../../../apple-icon-114x114.png">
    <link rel="apple-touch-icon" sizes="120x120" href="../../../apple-icon-120x120.png">
    <link rel="apple-touch-icon" sizes="144x144" href="../../../apple-icon-144x144.png">
    <link rel="apple-touch-icon" sizes="152x152" href="../../../apple-icon-152x152.png">
    <link rel="apple-touch-icon" sizes="180x180" href="../../../apple-icon-180x180.png">
    <link rel="icon" type="image/png" sizes="192x192" href="../../../android-icon-192x192.png">
    <link rel="icon" type="image/png" sizes="32x32" href="../../../favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="96x96" href="../../../favicon-96x96.png">
    <link rel="icon" type="image/png" sizes="16x16" href="../../../favicon-16x16.png">
    <link rel="manifest" href="/manifest.json">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="msapplication-TileImage" content="../../../ms-icon-144x144.png">
    <meta name="theme-color" content="#ffffff">
      <link rel="shortcut icon" href="../../../favicon.ico">
      <script defer="" src='https://static.cloudflareinsights.com/beacon.min.js' data-cf-beacon='{"token": "de6c22ce0b3e4c17bb78c8c31b4e695b"}'></script>
      <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;500;700&display=swap" rel="stylesheet">
      <link rel="stylesheet" href="//cdnjs.cloudflare.com/ajax/libs/highlight.js/11.7.0/styles/night-owl.min.css">
      <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.7.2/font/bootstrap-icons.css" integrity="sha384-EvBWSlnoFgZlXJvpzS+MAUEjvN7+gcCwH+qh7GRFOGgZO0PuwOFro7qPOJnLfe7l" crossorigin="anonymous">
      <link rel="stylesheet" href="../../../src/styles/config.css">
      <link rel="stylesheet" href="../../../src/styles/discord.css">
      <link rel="stylesheet" href="../../../src/styles/dcs.css">
      <link rel="stylesheet" href="../../../src/styles/main.css">
      <link rel="stylesheet" href="../../../src/styles/colors.css">
      <link rel="stylesheet" href="../../../src/styles/highlight/github-dark.min.css">
      <meta property="docfx:navrel" content="../../../toc.html">
      <meta property="docfx:tocrel" content="../../toc.html">
  
  <meta property="docfx:rel" content="../../../">
  <meta property="docfx:newtab" content="true">
    </head>

    <body>
        <div class="top-navbar">
            <a class="burger-icon" onclick="toggleMenu()">
                <svg name="Hamburger" style="vertical-align: middle;" width="34" height="34" viewbox="0 0 24 24"><path fill="currentColor" fill-rule="evenodd" clip-rule="evenodd" d="M20 6H4V9H20V6ZM4 10.999H20V13.999H4V10.999ZM4 15.999H20V18.999H4V15.999Z"></path></svg>
            </a>


            <a class="navbar-brand" href="../../../index.html">
              <img id="logo" class="svg" src="../../../dcs-logo-winter.gif" alt="DisCatSharp">
            </a>
        </div>

        <div class="body-content">
            <div id="blackout" class="blackout" onclick="toggleMenu()"></div>

            <nav id="sidebar" role="navigation">
                <div class="sidebar">

                    <div>
                      <div class="mobile-hide">

                        <a class="navbar-brand" href="../../../index.html">
                          <img id="logo" class="svg" src="../../../dcs-logo-winter.gif" alt="DisCatSharp">
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

                    <article class="content wrap" id="_content" data-uid="advanced_topics_select_menus">
<h1 id="introduction" sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="6" sourceendlinenumber="6">Introduction</h1>

<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="7" sourceendlinenumber="8">The select menus, like the <a class="xref" href="buttons.html" data-raw-source="[buttons](xref:advanced_topics_buttons)" sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="7" sourceendlinenumber="7">buttons</a>, are message components.
You will want to familarize yourself with the <a class="xref" href="../messagebuilder.html" data-raw-source="[message builder](xref:beyond_basics_messagebuilder)" sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="8" sourceendlinenumber="8">message builder</a> as it and similar builder objects will be used throughout this article.</p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="10" sourceendlinenumber="11">A row can only have one select menu. An row containing a select menu cannot also contain buttons.
Since a message can have up to 5 rows, you can add up to 5 select menus to a message.</p>
<h1 id="select-menus" sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="13" sourceendlinenumber="13">Select Menus</h1>
<div class="WARNING" sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="15" sourceendlinenumber="15"><h5>Warning</h5><p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="16" sourceendlinenumber="16">Component Ids and option values should be unique, as this is what&#39;s sent back when a user selects one (or more) option.</p>
</div>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="18" sourceendlinenumber="18">Select menus consist of five parts:</p>
<ul sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="19" sourceendlinenumber="24">
<li sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="19" sourceendlinenumber="19">Id</li>
<li sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="20" sourceendlinenumber="20">Placeholder</li>
<li sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="21" sourceendlinenumber="21">Options</li>
<li sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="22" sourceendlinenumber="22">MinOptions</li>
<li sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="23" sourceendlinenumber="23">MaxOptions</li>
<li sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="24" sourceendlinenumber="24">Disabled</li>
</ul>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="26" sourceendlinenumber="26">The id of the select menu is a settable string, and is specified by the developer. Discord sends this id back in the <a href="https://discord.dev/interactions/slash-commands#interaction" data-raw-source="[interaction object](https://discord.dev/interactions/slash-commands#interaction)" sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="26" sourceendlinenumber="26">interaction object</a>.</p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="28" sourceendlinenumber="28"><strong>Placeholder</strong> is a settable string that appears in the select menu when nothing is selected.</p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="30" sourceendlinenumber="31"><strong>Options</strong> is an array of options for the user to select. Their maximum number in one select menu is 25.
You can let users choose 1 or more options using <strong>MinOptions</strong> and <strong>MaxOptions</strong>.</p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="33" sourceendlinenumber="33">Options consist of five parts:</p>
<ul sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="34" sourceendlinenumber="38">
<li sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="34" sourceendlinenumber="34">Label</li>
<li sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="35" sourceendlinenumber="35">Value</li>
<li sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="36" sourceendlinenumber="36">Description</li>
<li sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="37" sourceendlinenumber="37">IsDefault</li>
<li sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="38" sourceendlinenumber="38">Emoji</li>
</ul>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="40" sourceendlinenumber="40">Menu creation, for easier understanding, can be divided into two stages:</p>
<pre sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="42" sourceendlinenumber="52"><code class="lang-cs">// First, create an array of options.
var options = new DiscordSelectComponentOption[]
{
    new DiscordSelectComponentOption(&quot;First option&quot;, &quot;first_option&quot;, &quot;This is the first option, you can add your description of it here.&quot;, false, new DiscordComponentEmoji(&quot;😀&quot;)),
    new DiscordSelectComponentOption(&quot;Second option&quot;, &quot;second_option&quot;, &quot;This is the second option, you can add your description of it here.&quot;, false, new DiscordComponentEmoji(&quot;😎&quot;))
};

// Now let&#39;s create a select menu with the options created above.
var selectMenu = new DiscordSelectComponent(&quot;my_select_menu&quot;, &quot;Please select one of the options&quot;, options);
</code></pre><p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="54" sourceendlinenumber="56">This will create a select menu with two options and the text &quot;Please select one of the options&quot;.
When a user select <strong>one</strong> option, <code>&quot;my_select_menu&quot;</code> will be sent back as the <code>Id</code> property on the event.
This is expanded on in the <a href="#responding-to-select-menus" data-raw-source="[how to respond to select menus](#responding-to-select-menus)" sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="56" sourceendlinenumber="56">how to respond to select menus</a>.</p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="58" sourceendlinenumber="58">You can increase the maximum/minimum number of selections in the select menu constructor. You can also block the select menu, or options.</p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="60" sourceendlinenumber="61">Description and emoji of options are optional. The label, value and description can be up to 100 characters in length.
The emoji of a option is a <a href="https://discord.dev/interactions/message-components#component-object" data-raw-source="[partial emoji object](https://discord.dev/interactions/message-components#component-object)" sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="61" sourceendlinenumber="61">partial emoji object</a>, which means that <strong>any valid emoji is usable</strong>, even if your bot does not have access to it&#39;s origin server.</p>
<h1 id="adding-select-menu" sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="64" sourceendlinenumber="64">Adding Select Menu</h1>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="66" sourceendlinenumber="67">Adding a select menu is no different than adding a button.
We have already created the select menu above, now we will just create a new message builder add the select menu to it.</p>
<pre sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="69" sourceendlinenumber="73"><code class="lang-cs">var builder = new DiscordMessageBuilder()
    .WithContent(&quot;This message has select menu! Pretty neat innit?&quot;)
    .AddComponents(selectMenu);
</code></pre><p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="74" sourceendlinenumber="74">Now you have a message with a select menu. Congratulations! It&#39;s important to note that <code>.AddComponents()</code> will create a new row with each call, so <strong>add everything you want on one row in one call!</strong></p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="76" sourceendlinenumber="76">Lets also add a second row with select menu with the ability to choose any number of options.</p>
<pre sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="78" sourceendlinenumber="89"><code class="lang-cs">var secondOptions = new DiscordSelectComponentOption[]
{
    new DiscordSelectComponentOption(&quot;First option&quot;, &quot;first_option&quot;, &quot;This is the first option, you can add your description of it here.&quot;, false, new DiscordComponentEmoji(&quot;😀&quot;)),
    new DiscordSelectComponentOption(&quot;Second option&quot;, &quot;second_option&quot;, &quot;This is the second option, you can add your description of it here.&quot;, false, new DiscordComponentEmoji(&quot;😎&quot;))
    new DiscordSelectComponentOption(&quot;Third option&quot;, &quot;third_option&quot;, &quot;This is the third option, you can add your description of it here.&quot;, false, new DiscordComponentEmoji(&quot;😘&quot;))
};

var secondSelectMenu = new DiscordSelectComponent(&quot;my_second_select_menu&quot;, &quot;Please select up to 3 options&quot;, secondOptions, 1, 3);

builder.AddComponents(secondSelectMenu);
</code></pre><p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="90" sourceendlinenumber="90">And you&#39;re done! The select menu will now be sent when the user closes the select menu with 1 to 3 options selected.</p>
<h1 id="responding-to-select-menus" sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="93" sourceendlinenumber="93">Responding to select menus</h1>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="95" sourceendlinenumber="95">When any select menu is pressed, it will fire the <a class="xref" href="../../../api/DisCatSharp/DisCatSharp.DiscordClient.html#DisCatSharp_DiscordClient_ComponentInteractionCreated" data-raw-source="[ComponentInteractionCreated](xref:DisCatSharp.DiscordClient#DisCatSharp_DiscordClient_ComponentInteractionCreated)" sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="95" sourceendlinenumber="95">ComponentInteractionCreated</a> event.</p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="97" sourceendlinenumber="97">In the event args, <code>Id</code> will be the id of the select menu you specified. There&#39;s also an <code>Interaction</code> property, which contains the interaction the event created. It&#39;s important to respond to an interaction within 3 seconds, or it will time out. Responding after this period will throw a <code>NotFoundException</code>.</p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="99" sourceendlinenumber="99">With select menus, there are two new response types: <code>DefferedMessageUpdate</code> and <code>UpdateMessage</code>.</p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="101" sourceendlinenumber="101">Using <code>DeferredMessageUpdate</code> lets you create followup messages via the <a class="xref" href="../../../api/DisCatSharp/DisCatSharp.Entities.DiscordFollowupMessageBuilder.html" data-raw-source="[followup message builder](xref:DisCatSharp.Entities.DiscordFollowupMessageBuilder)" sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="101" sourceendlinenumber="101">followup message builder</a>.</p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="103" sourceendlinenumber="103">You have 15 minutes from that point to make followup messages. Responding to that interaction looks like this:</p>
<pre sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="105" sourceendlinenumber="111"><code class="lang-cs">client.ComponentInteractionCreated += async (s, e) =&gt;
{
    await e.Interaction.CreateResponseAsync(InteractionResponseType.DefferedMessageUpdate);
    // Do things.. //
}
</code></pre><p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="113" sourceendlinenumber="113">If you would like to update the message when an select menu option selected, however, you&#39;d use <code>UpdateMessage</code> instead, and pass a <code>DiscordInteractionResponseBuilder</code> with the new content you&#39;d like.</p>
<pre sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="115" sourceendlinenumber="120"><code class="lang-cs">client.ComponentInteractionCreated += async (s, e) =&gt;
{
    await e.Interaction.CreateResponseAsync(InteractionResponseType.UpdateMessage, new DiscordInteractionResponseBuilder().WithContent(&quot;No more select menu for you &gt;:)&quot;));
}
</code></pre><p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="121" sourceendlinenumber="121">This will update the message, and without the infamous <sub>(edited)</sub> next to it. Nice.</p>
<h1 id="interactivity" sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="124" sourceendlinenumber="124">Interactivity</h1>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="125" sourceendlinenumber="125">Along with the typical <code>WaitForMessageAsync</code> and <code>WaitForReactionAsync</code> methods provided by interactivity, there are also select menus implementations as well.</p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="127" sourceendlinenumber="127">More information about how interactivity works can be found in <a class="xref" href="../../modules/interactivity.html" data-raw-source="[the interactivity article](xref:modules_interactivity)" sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="127" sourceendlinenumber="127">the interactivity article</a></p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="129" sourceendlinenumber="129">Since select menus create interactions, there are also two additional properties in the configuration:</p>
<ul sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="130" sourceendlinenumber="131">
<li sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="130" sourceendlinenumber="130">ResponseBehavior</li>
<li sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="131" sourceendlinenumber="131">ResponseMessage</li>
</ul>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="133" sourceendlinenumber="133">ResponseBehavior is what interactivity will do when handling something that isn&#39;t a valid select menu, in the context of waiting for a specific select menu. It defaults to <code>Ignore</code>, which will cause the interaction fail.</p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="135" sourceendlinenumber="135">Alternatively, setting it to <code>Ack</code> will acknowledge the select menu, and continue waiting.</p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="137" sourceendlinenumber="137">Respond will reply with an ephemeral message with the aforementioned response message.</p>
<p sourcefile="articles/beyond_basics/components/select_menus.md" sourcestartlinenumber="139" sourceendlinenumber="139">ResponseBehavior only applies to the overload accepting a string id of the select menu to wait for.</p>
</article>
                </div>

                <div class="copyright-footer">
                    <span>&#169; Aiko IT Systems. All rights reserved.</span>
                </div>
            </div></main>
        </div>


        <script src="https://code.jquery.com/jquery-3.5.1.min.js" integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=" crossorigin="anonymous"></script>
        <script type="text/javascript" src="../../../src/scripts/docfx.vendor.js"></script>
        <script type="text/javascript" src="../../../src/scripts/docfx.js"></script>
        <script type="text/javascript" src="../../../src/scripts/url.min.js"></script>
        <script type="text/javascript" src="../../../src/scripts/highlight/highlight.min.js"></script>
        <script>hljs.highlightAll();</script>
        <script src="https://cdn.jsdelivr.net/npm/anchor-js/anchor.min.js"></script>
        <script type="text/javascript" src="../../../src/scripts/jquery.twbsPagination.js"></script>
        <script type="text/javascript" src="../../../src/scripts/dcs.js"></script>
        <script type="text/javascript" src="../../../src/scripts/lunr.js"></script>
    </body>
</html>