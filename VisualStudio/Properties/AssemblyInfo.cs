﻿using BuildInfo = WolvesComeOutAtNight.BuildInfo;

[assembly: AssemblyTitle(BuildInfo.Name)]
[assembly: AssemblyDescription(BuildInfo.Description)]
[assembly: AssemblyCompany(BuildInfo.Company)]
[assembly: AssemblyProduct(BuildInfo.Product)]
[assembly: AssemblyCopyright(BuildInfo.Copyright)]
[assembly: AssemblyTrademark(BuildInfo.Trademark)]
[assembly: AssemblyCulture(BuildInfo.Culture)]

[assembly: AssemblyVersion(BuildInfo.Version)]
[assembly: AssemblyFileVersion(BuildInfo.Version)]
[assembly: MelonInfo(typeof(WolvesComeOutAtNight.WolvesComeOutAtNight), BuildInfo.Name, BuildInfo.Version, BuildInfo.Author, BuildInfo.DownloadLink)]
[assembly: MelonGame("Hinterland", "TheLongDark")]
