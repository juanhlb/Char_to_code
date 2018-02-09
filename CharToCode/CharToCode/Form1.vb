Imports System
Imports System.IO
Imports System.Collections
Public Class FRMMain
    Dim AscCode(256) As String
    Dim Ruta As String
    'Necesitará una variable de cadena en la que almacenar cada línea del archivo a medida que procesa. Como estas cadenas las agregará a una ArrayList, declare y cree también un objeto de ese tipo.
    Dim sLine As String = ""
    Dim arrText As New ArrayList()

    Private Sub FRMMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LBLproceced.Text = ""
        'array para método 2
        AscCode(0) = "00000000"
        AscCode(1) = "00000001"
        AscCode(2) = "00000010"
        AscCode(3) = "00000011"
        AscCode(4) = "00000100"
        AscCode(5) = "00000101"
        AscCode(6) = "00000110"
        AscCode(7) = "00000111"
        AscCode(8) = "00001000"
        AscCode(9) = "00001001"
        AscCode(10) = "00001010"
        AscCode(11) = "00001011"
        AscCode(12) = "00001100"
        AscCode(13) = "00001101"
        AscCode(14) = "00001110"
        AscCode(15) = "00001111"
        AscCode(16) = "00010000"
        AscCode(17) = "00010001"
        AscCode(18) = "00010010"
        AscCode(19) = "00010011"
        AscCode(20) = "00010100"
        AscCode(21) = "00010101"
        AscCode(22) = "00010110"
        AscCode(23) = "00010111"
        AscCode(24) = "00011000"
        AscCode(25) = "00011001"
        AscCode(26) = "00011010"
        AscCode(27) = "00011011"
        AscCode(28) = "00011100"
        AscCode(29) = "00011101"
        AscCode(30) = "00011110"
        AscCode(31) = "00011111"
        AscCode(32) = "00100000"
        AscCode(33) = "00100001"
        AscCode(34) = "00100010"
        AscCode(35) = "00100011"
        AscCode(36) = "00100100"
        AscCode(37) = "00100101"
        AscCode(38) = "00100110"
        AscCode(39) = "00100111"
        AscCode(40) = "00101000"
        AscCode(41) = "00101001"
        AscCode(42) = "00101010"
        AscCode(43) = "00101011"
        AscCode(44) = "00101100"
        AscCode(45) = "00101101"
        AscCode(46) = "00101110"
        AscCode(47) = "00101111"
        AscCode(48) = "00110000"
        AscCode(49) = "00110001"
        AscCode(50) = "00110010"
        AscCode(51) = "00110011"
        AscCode(52) = "00110100"
        AscCode(53) = "00110101"
        AscCode(54) = "00110110"
        AscCode(55) = "00110111"
        AscCode(56) = "00111000"
        AscCode(57) = "00111001"
        AscCode(58) = "00111010"
        AscCode(59) = "00111011"
        AscCode(60) = "00111100"
        AscCode(61) = "00111101"
        AscCode(62) = "00111110"
        AscCode(63) = "00111111"
        AscCode(64) = "01000000"
        AscCode(65) = "01000001"
        AscCode(66) = "01000010"
        AscCode(67) = "01000011"
        AscCode(68) = "01000100"
        AscCode(69) = "01000101"
        AscCode(70) = "01000110"
        AscCode(71) = "01000111"
        AscCode(72) = "01001000"
        AscCode(73) = "01001001"
        AscCode(74) = "01001010"
        AscCode(75) = "01001011"
        AscCode(76) = "01001100"
        AscCode(77) = "01001101"
        AscCode(78) = "01001110"
        AscCode(79) = "01001111"
        AscCode(80) = "01010000"
        AscCode(81) = "01010001"
        AscCode(82) = "01010010"
        AscCode(83) = "01010011"
        AscCode(84) = "01010100"
        AscCode(85) = "01010101"
        AscCode(86) = "01010110"
        AscCode(87) = "01010111"
        AscCode(88) = "01011000"
        AscCode(89) = "01011001"
        AscCode(90) = "01011010"
        AscCode(91) = "01011011"
        AscCode(92) = "01011100"
        AscCode(93) = "01011101"
        AscCode(94) = "01011110"
        AscCode(95) = "01011111"
        AscCode(96) = "01100000"
        AscCode(97) = "01100001"
        AscCode(98) = "01100010"
        AscCode(99) = "01100011"
        AscCode(100) = "01100100"
        AscCode(101) = "01100101"
        AscCode(102) = "01100110"
        AscCode(103) = "01100111"
        AscCode(104) = "01101000"
        AscCode(105) = "01101001"
        AscCode(106) = "01101010"
        AscCode(107) = "01101011"
        AscCode(108) = "01101100"
        AscCode(109) = "01101101"
        AscCode(110) = "01101110"
        AscCode(111) = "01101111"
        AscCode(112) = "01110000"
        AscCode(113) = "01110001"
        AscCode(114) = "01110010"
        AscCode(115) = "01110011"
        AscCode(116) = "01110100"
        AscCode(117) = "01110101"
        AscCode(118) = "01110110"
        AscCode(119) = "01110111"
        AscCode(120) = "01111000"
        AscCode(121) = "01111001"
        AscCode(122) = "01111010"
        AscCode(123) = "01111011"
        AscCode(124) = "01111100"
        AscCode(125) = "01111101"
        AscCode(126) = "01111110"
        AscCode(127) = "01111111"
        AscCode(128) = "10000000"
        AscCode(129) = "10000001"
        AscCode(130) = "10000010"
        AscCode(131) = "10000011"
        AscCode(132) = "10000100"
        AscCode(133) = "10000101"
        AscCode(134) = "10000110"
        AscCode(135) = "10000111"
        AscCode(136) = "10001000"
        AscCode(137) = "10001001"
        AscCode(138) = "10001010"
        AscCode(139) = "10001011"
        AscCode(140) = "10001100"
        AscCode(141) = "10001101"
        AscCode(142) = "10001110"
        AscCode(143) = "10001111"
        AscCode(144) = "10010000"
        AscCode(145) = "10010001"
        AscCode(146) = "10010010"
        AscCode(147) = "10010011"
        AscCode(148) = "10010100"
        AscCode(149) = "10010101"
        AscCode(150) = "10010110"
        AscCode(151) = "10010111"
        AscCode(152) = "10011000"
        AscCode(153) = "10011001"
        AscCode(154) = "10011010"
        AscCode(155) = "10011011"
        AscCode(156) = "10011100"
        AscCode(157) = "10011101"
        AscCode(158) = "10011110"
        AscCode(159) = "10011111"
        AscCode(160) = "10100000"
        AscCode(161) = "10100001"
        AscCode(162) = "10100010"
        AscCode(163) = "10100011"
        AscCode(164) = "10100100"
        AscCode(165) = "10100101"
        AscCode(166) = "10100110"
        AscCode(167) = "10100111"
        AscCode(168) = "10101000"
        AscCode(169) = "10101001"
        AscCode(170) = "10101010"
        AscCode(171) = "10101011"
        AscCode(172) = "10101100"
        AscCode(173) = "10101101"
        AscCode(174) = "10101110"
        AscCode(175) = "10101111"
        AscCode(176) = "10110000"
        AscCode(177) = "10110001"
        AscCode(178) = "10110010"
        AscCode(179) = "10110011"
        AscCode(180) = "10110100"
        AscCode(181) = "10110101"
        AscCode(182) = "10110110"
        AscCode(183) = "10110111"
        AscCode(184) = "10111000"
        AscCode(185) = "10111001"
        AscCode(186) = "10111010"
        AscCode(187) = "10111011"
        AscCode(188) = "10111100"
        AscCode(189) = "10111101"
        AscCode(190) = "10111110"
        AscCode(191) = "10111111"
        AscCode(192) = "11000000"
        AscCode(193) = "11000001"
        AscCode(194) = "11000010"
        AscCode(195) = "11000011"
        AscCode(196) = "11000100"
        AscCode(197) = "11000101"
        AscCode(198) = "11000110"
        AscCode(199) = "11000111"
        AscCode(200) = "11001000"
        AscCode(201) = "11001001"
        AscCode(202) = "11001010"
        AscCode(203) = "11001011"
        AscCode(204) = "11001100"
        AscCode(205) = "11001101"
        AscCode(206) = "11001110"
        AscCode(207) = "11001111"
        AscCode(208) = "11010000"
        AscCode(209) = "11010001"
        AscCode(210) = "11010010"
        AscCode(211) = "11010011"
        AscCode(212) = "11010100"
        AscCode(213) = "11010101"
        AscCode(214) = "11010110"
        AscCode(215) = "11010111"
        AscCode(216) = "11011000"
        AscCode(217) = "11011001"
        AscCode(218) = "11011010"
        AscCode(219) = "11011011"
        AscCode(220) = "11011100"
        AscCode(221) = "11011101"
        AscCode(222) = "11011110"
        AscCode(223) = "11011111"
        AscCode(224) = "11100000"
        AscCode(225) = "11100001"
        AscCode(226) = "11100010"
        AscCode(227) = "11100011"
        AscCode(228) = "11100100"
        AscCode(229) = "11100101"
        AscCode(230) = "11100110"
        AscCode(231) = "11100111"
        AscCode(232) = "11101000"
        AscCode(233) = "11101001"
        AscCode(234) = "11101010"
        AscCode(235) = "11101011"
        AscCode(236) = "11101100"
        AscCode(237) = "11101101"
        AscCode(238) = "11101110"
        AscCode(239) = "11101111"
        AscCode(240) = "11110000"
        AscCode(241) = "11110001"
        AscCode(242) = "11110010"
        AscCode(243) = "11110011"
        AscCode(244) = "11110100"
        AscCode(245) = "11110101"
        AscCode(246) = "11110110"
        AscCode(247) = "11110111"
        AscCode(248) = "11111000"
        AscCode(249) = "11111001"
        AscCode(250) = "11111010"
        AscCode(251) = "11111011"
        AscCode(252) = "11111100"
        AscCode(253) = "11111101"
        AscCode(254) = "11111110"
        AscCode(255) = "11111111"


      


    End Sub

    Private Sub TransformByteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransformByteToolStripMenuItem.Click
        Dim val As String = Nothing
        Dim Result As New System.Text.StringBuilder
        For Each Character As Byte In System.Text.ASCIIEncoding.ASCII.GetBytes(TXTwriteText.Text)
            Result.Append(Convert.ToString(Character, 2).PadLeft(8, "0"))
            Result.Append(" ")
        Next
        val = Result.ToString.Substring(0, Result.ToString.Length - 1)
        TXTOutput.Text = val
    End Sub

    Private Sub ExampleTxtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExampleTxtToolStripMenuItem.Click
        TXTwriteText.Text = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi."

        TXTwriteText.Text += "Expetenda tincidunt in sed, ex partem placerat sea, porro commodo ex eam. His putant aeterno interesset at. Usu ea mundi tincidunt, omnium virtute aliquando ius ex. Ea aperiri sententiae duo. Usu nullam dolorum quaestio ei, sit vidit facilisis ea. Per ne impedit iracundia neglegentur. Consetetur neglegentur eum ut, vis animal legimus inimicus id."

        TXTwriteText.Text += "His audiam deserunt in, eum ubique voluptatibus te. In reque dicta usu. Ne rebum dissentiet eam, vim omnis deseruisse id. Ullum deleniti vituperata at quo, insolens complectitur te eos, ea pri dico munere propriae. Vel ferri facilis ut, qui paulo ridens praesent ad. Possim alterum qui cu. Accusamus consulatu ius te, cu decore soleat appareat usu."

        TXTwriteText.Text += "Est ei erat mucius quaeque. Ei his quas phaedrum, efficiantur mediocritatem ne sed, hinc oratio blandit ei sed. Blandit gloriatur eam et. Brute noluisse per et, verear disputando neglegentur at quo. Sea quem legere ei, unum soluta ne duo. Ludus complectitur quo te, ut vide autem homero pro."

        TXTwriteText.Text += "Vis id minim dicant sensibus. Pri aliquip conclusionemque ad, ad malis evertitur torquatos his. Has ei solum harum reprimique, id illum saperet tractatos his. Ei omnis soleat antiopam quo. Ad augue inani postulant mel, mel ea qualisque forensibus."

        TXTwriteText.Text += "Lorem salutandi eu mea, eam in soleat iriure assentior. Tamquam lobortis id qui. Ea sanctus democritum mei, per eu alterum electram adversarium. Ea vix probo dicta iuvaret, posse epicurei suavitate eam an, nam et vidit menandri. Ut his accusata petentium."

        TXTwriteText.Text += "Meis vocent signiferumque pri et. Facilis corpora recusabo ne quo, eum ne eruditi blandit suscipiantur. Mazim sapientem sed id, sea debet commune iracundia in. Eius falli propriae te usu. In usu nonummy volumus expetenda, sint quando facilisis ei per, delectus constituto sea te."

        TXTwriteText.Text += "Wisi forensibus mnesarchum in cum. Per id impetus abhorreant, his no magna definiebas, inani rationibus in quo. Ut vidisse dolores est, ut quis nominavi mel. Ad pri quod apeirian concludaturque, id timeam iudicabit rationibus pri. Erant putant luptatum ex sit, error euismod ad qui, meliore voluptatum complectitur an vix. Clita persius sed et, vix vidit consulatu complectitur ex. Per nonummy postulant assentior an, mea audiam fabellas deserunt id."

        TXTwriteText.Text += "Cu nam labores lobortis definiebas, ei aliquyam salutatus persequeris quo, cum eu nemore fierent dissentiunt. Per vero dolor id, vide democritum scribentur eu vim, pri erroribus temporibus ex. Euismod molestie offendit has no. Quo te semper invidunt quaestio, per vituperatoribus sadipscing ei, partem aliquyam sensibus in cum."

        TXTwriteText.Text += "Mei eu mollis albucius, ex nisl contentiones vix. Duo persius volutpat at, cu iuvaret epicuri mei. Duo posse pertinacia no, ex dolor contentiones mea. Nec omnium utamur dignissim ne. Mundi lucilius salutandi an sea, ne sea aeque iudico comprehensam. Populo delicatissimi ad pri. Ex vitae accusam vivendum pro."

        TXTwriteText.Text += "An vim commodo dolorem volutpat, cu expetendis voluptatum usu, et mutat consul adversarium his. His natum numquam legimus an, diam fabulas mei ut. Melius fabellas sadipscing vel id. Partem diceret mandamus mea ne, has te tempor nostrud. Aeque nostro eum no."

        TXTwriteText.Text += "Eam ex integre quaeque bonorum, ea assum solet scriptorem pri, et usu nonummy accusata interpretaris. Debitis necessitatibus est no. Eu probo graeco eum, at eius choro sit, possit recusabo corrumpit vim ne. Noster diceret delicata vel id."

        TXTwriteText.Text += "Dicunt percipit deserunt ut usu. Aliquip delenit an eam, vocent vituperata vim ea. Ei mollis audire interpretaris cum, ei impedit fierent sea. Ius at homero noster prompta, ea sit dignissim vituperata efficiendi. Natum placerat ad mei."

        TXTwriteText.Text += "At cum soleat disputationi, quo veri admodum vituperata ad. Ea vix ceteros complectitur, vel cu nihil nullam. Nam placerat oporteat molestiae ei, an putant albucius qui. Oblique menandri ei his, mei te mazim oportere comprehensam."

        TXTwriteText.Text += "In mel saperet expetendis. Vitae urbanitas sadipscing nec ut, at vim quis lorem labitur. Exerci electram has et, vidit solet tincidunt quo ad, moderatius contentiones nec no. Nam et puto abhorreant scripserit, et cum inimicus accusamus."

        TXTwriteText.Text += "Has maiorum habemus detraxit at. Timeam fabulas splendide et his. Facilisi aliquando sea ad, vel ne consetetur adversarium. Integre admodum et his, nominavi urbanitas et per, alii reprehendunt et qui. His ei meis legere nostro, eu kasd fabellas definiebas mei, in sea augue iriure."

        TXTwriteText.Text += "Senserit mediocrem vis ex, et dicunt deleniti gubergren mei. Mel id clita mollis repudiare. Sed ad nostro delicatissimi, postea pertinax est an. Adhuc sensibus percipitur sed te, eirmod tritani debitis nec ea. Cu vis quis gubergren."

        TXTwriteText.Text += "At quaeque adversarium ius, sed at integre persius verterem. Sit summo tibique at, eam et fugit complectitur, vis te natum vivendum mandamus. Iudico quodsi cum ad, dicit everti sensibus in sea, ea eius paulo deterruisset pri. Pro id aliquam hendrerit definitiones. Per et legimus delectus."

        TXTwriteText.Text += "No his munere interesset. At soluta accusam gloriatur eos, ferri commodo sed id, ei tollit legere nec. Eum et iudico graecis, cu zzril instructior per, usu at augue epicurei. Saepe scaevola takimata vix id. Errem dictas posidonium id vis, ne modo affert incorrupte eos."

        TXTwriteText.Text += "Virtute equidem ceteros in mel. Id volutpat neglegentur eos. Eu eum facilisis voluptatum, no eam albucius verterem. Sit congue platonem adolescens ut. Offendit reprimique et has, eu mei homero imperdiet."

        TXTwriteText.Text += "Id sea utamur aperiam, te per choro accusamus consulatu. Brute munere corrumpit ut pri. Ea ipsum appareat erroribus mea. Mei probo inani aliquid ad. Omnis fabulas concludaturque an vix, an noluisse takimata facilisis pro, sit te volumus mandamus. Ad malorum imperdiet duo, ea possim utamur accusamus vix."

        TXTwriteText.Text += "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi."

        TXTwriteText.Text += "Expetenda tincidunt in sed, ex partem placerat sea, porro commodo ex eam. His putant aeterno interesset at. Usu ea mundi tincidunt, omnium virtute aliquando ius ex. Ea aperiri sententiae duo. Usu nullam dolorum quaestio ei, sit vidit facilisis ea. Per ne impedit iracundia neglegentur. Consetetur neglegentur eum ut, vis animal legimus inimicus id."

        TXTwriteText.Text += "His audiam deserunt in, eum ubique voluptatibus te. In reque dicta usu. Ne rebum dissentiet eam, vim omnis deseruisse id. Ullum deleniti vituperata at quo, insolens complectitur te eos, ea pri dico munere propriae. Vel ferri facilis ut, qui paulo ridens praesent ad. Possim alterum qui cu. Accusamus consulatu ius te, cu decore soleat appareat usu."

        TXTwriteText.Text += "Est ei erat mucius quaeque. Ei his quas phaedrum, efficiantur mediocritatem ne sed, hinc oratio blandit ei sed. Blandit gloriatur eam et. Brute noluisse per et, verear disputando neglegentur at quo. Sea quem legere ei, unum soluta ne duo. Ludus complectitur quo te, ut vide autem homero pro."

        TXTwriteText.Text += "Vis id minim dicant sensibus. Pri aliquip conclusionemque ad, ad malis evertitur torquatos his. Has ei solum harum reprimique, id illum saperet tractatos his. Ei omnis soleat antiopam quo. Ad augue inani postulant mel, mel ea qualisque forensibus."

        TXTwriteText.Text += "Lorem salutandi eu mea, eam in soleat iriure assentior. Tamquam lobortis id qui. Ea sanctus democritum mei, per eu alterum electram adversarium. Ea vix probo dicta iuvaret, posse epicurei suavitate eam an, nam et vidit menandri. Ut his accusata petentium."

        TXTwriteText.Text += "Meis vocent signiferumque pri et. Facilis corpora recusabo ne quo, eum ne eruditi blandit suscipiantur. Mazim sapientem sed id, sea debet commune iracundia in. Eius falli propriae te usu. In usu nonummy volumus expetenda, sint quando facilisis ei per, delectus constituto sea te."

        TXTwriteText.Text += "Wisi forensibus mnesarchum in cum. Per id impetus abhorreant, his no magna definiebas, inani rationibus in quo. Ut vidisse dolores est, ut quis nominavi mel. Ad pri quod apeirian concludaturque, id timeam iudicabit rationibus pri. Erant putant luptatum ex sit, error euismod ad qui, meliore voluptatum complectitur an vix. Clita persius sed et, vix vidit consulatu complectitur ex. Per nonummy postulant assentior an, mea audiam fabellas deserunt id."

        TXTwriteText.Text += "Cu nam labores lobortis definiebas, ei aliquyam salutatus persequeris quo, cum eu nemore fierent dissentiunt. Per vero dolor id, vide democritum scribentur eu vim, pri erroribus temporibus ex. Euismod molestie offendit has no. Quo te semper invidunt quaestio, per vituperatoribus sadipscing ei, partem aliquyam sensibus in cum."

        TXTwriteText.Text += "Mei eu mollis albucius, ex nisl contentiones vix. Duo persius volutpat at, cu iuvaret epicuri mei. Duo posse pertinacia no, ex dolor contentiones mea. Nec omnium utamur dignissim ne. Mundi lucilius salutandi an sea, ne sea aeque iudico comprehensam. Populo delicatissimi ad pri. Ex vitae accusam vivendum pro."

        TXTwriteText.Text += "An vim commodo dolorem volutpat, cu expetendis voluptatum usu, et mutat consul adversarium his. His natum numquam legimus an, diam fabulas mei ut. Melius fabellas sadipscing vel id. Partem diceret mandamus mea ne, has te tempor nostrud. Aeque nostro eum no."

        TXTwriteText.Text += "Eam ex integre quaeque bonorum, ea assum solet scriptorem pri, et usu nonummy accusata interpretaris. Debitis necessitatibus est no. Eu probo graeco eum, at eius choro sit, possit recusabo corrumpit vim ne. Noster diceret delicata vel id."

        TXTwriteText.Text += "Dicunt percipit deserunt ut usu. Aliquip delenit an eam, vocent vituperata vim ea. Ei mollis audire interpretaris cum, ei impedit fierent sea. Ius at homero noster prompta, ea sit dignissim vituperata efficiendi. Natum placerat ad mei."

        TXTwriteText.Text += "At cum soleat disputationi, quo veri admodum vituperata ad. Ea vix ceteros complectitur, vel cu nihil nullam. Nam placerat oporteat molestiae ei, an putant albucius qui. Oblique menandri ei his, mei te mazim oportere comprehensam."

        TXTwriteText.Text += "In mel saperet expetendis. Vitae urbanitas sadipscing nec ut, at vim quis lorem labitur. Exerci electram has et, vidit solet tincidunt quo ad, moderatius contentiones nec no. Nam et puto abhorreant scripserit, et cum inimicus accusamus."

        TXTwriteText.Text += "Has maiorum habemus detraxit at. Timeam fabulas splendide et his. Facilisi aliquando sea ad, vel ne consetetur adversarium. Integre admodum et his, nominavi urbanitas et per, alii reprehendunt et qui. His ei meis legere nostro, eu kasd fabellas definiebas mei, in sea augue iriure."

        TXTwriteText.Text += "Senserit mediocrem vis ex, et dicunt deleniti gubergren mei. Mel id clita mollis repudiare. Sed ad nostro delicatissimi, postea pertinax est an. Adhuc sensibus percipitur sed te, eirmod tritani debitis nec ea. Cu vis quis gubergren."

        TXTwriteText.Text += "At quaeque adversarium ius, sed at integre persius verterem. Sit summo tibique at, eam et fugit complectitur, vis te natum vivendum mandamus. Iudico quodsi cum ad, dicit everti sensibus in sea, ea eius paulo deterruisset pri. Pro id aliquam hendrerit definitiones. Per et legimus delectus."

        TXTwriteText.Text += "No his munere interesset. At soluta accusam gloriatur eos, ferri commodo sed id, ei tollit legere nec. Eum et iudico graecis, cu zzril instructior per, usu at augue epicurei. Saepe scaevola takimata vix id. Errem dictas posidonium id vis, ne modo affert incorrupte eos."

        TXTwriteText.Text += "Virtute equidem ceteros in mel. Id volutpat neglegentur eos. Eu eum facilisis voluptatum, no eam albucius verterem. Sit congue platonem adolescens ut. Offendit reprimique et has, eu mei homero imperdiet."

        TXTwriteText.Text += "Id sea utamur aperiam, te per choro accusamus consulatu. Brute munere corrumpit ut pri. Ea ipsum appareat erroribus mea. Mei probo inani aliquid ad. Omnis fabulas concludaturque an vix, an noluisse takimata facilisis pro, sit te volumus mandamus. Ad malorum imperdiet duo, ea possim utamur accusamus vix."

        TXTwriteText.Text += "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi."

        TXTwriteText.Text += "Expetenda tincidunt in sed, ex partem placerat sea, porro commodo ex eam. His putant aeterno interesset at. Usu ea mundi tincidunt, omnium virtute aliquando ius ex. Ea aperiri sententiae duo. Usu nullam dolorum quaestio ei, sit vidit facilisis ea. Per ne impedit iracundia neglegentur. Consetetur neglegentur eum ut, vis animal legimus inimicus id."

        TXTwriteText.Text += "His audiam deserunt in, eum ubique voluptatibus te. In reque dicta usu. Ne rebum dissentiet eam, vim omnis deseruisse id. Ullum deleniti vituperata at quo, insolens complectitur te eos, ea pri dico munere propriae. Vel ferri facilis ut, qui paulo ridens praesent ad. Possim alterum qui cu. Accusamus consulatu ius te, cu decore soleat appareat usu."

        TXTwriteText.Text += "Est ei erat mucius quaeque. Ei his quas phaedrum, efficiantur mediocritatem ne sed, hinc oratio blandit ei sed. Blandit gloriatur eam et. Brute noluisse per et, verear disputando neglegentur at quo. Sea quem legere ei, unum soluta ne duo. Ludus complectitur quo te, ut vide autem homero pro."

        TXTwriteText.Text += "Vis id minim dicant sensibus. Pri aliquip conclusionemque ad, ad malis evertitur torquatos his. Has ei solum harum reprimique, id illum saperet tractatos his. Ei omnis soleat antiopam quo. Ad augue inani postulant mel, mel ea qualisque forensibus."

        TXTwriteText.Text += "Lorem salutandi eu mea, eam in soleat iriure assentior. Tamquam lobortis id qui. Ea sanctus democritum mei, per eu alterum electram adversarium. Ea vix probo dicta iuvaret, posse epicurei suavitate eam an, nam et vidit menandri. Ut his accusata petentium."

        TXTwriteText.Text += "Meis vocent signiferumque pri et. Facilis corpora recusabo ne quo, eum ne eruditi blandit suscipiantur. Mazim sapientem sed id, sea debet commune iracundia in. Eius falli propriae te usu. In usu nonummy volumus expetenda, sint quando facilisis ei per, delectus constituto sea te."

        TXTwriteText.Text += "Wisi forensibus mnesarchum in cum. Per id impetus abhorreant, his no magna definiebas, inani rationibus in quo. Ut vidisse dolores est, ut quis nominavi mel. Ad pri quod apeirian concludaturque, id timeam iudicabit rationibus pri. Erant putant luptatum ex sit, error euismod ad qui, meliore voluptatum complectitur an vix. Clita persius sed et, vix vidit consulatu complectitur ex. Per nonummy postulant assentior an, mea audiam fabellas deserunt id."

    End Sub

    Private Sub OpenTxtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenTxtToolStripMenuItem.Click
        With OFD
            .CheckFileExists = True
            ' Comprobar que la ruta de acceso seleccionada existe. El cuadro de diálogo muestra una advertencia en caso contrario.
            .CheckPathExists = True
            ' Obtener o establecer una extensión predeterminada. No incluye el "." inicial.
            .DefaultExt = "txt"
            ' ¿Devolver el archivo al que hace referencia un vínculo? Si False, devuelve el archivo de vínculo seleccionado. Si True, devuelve el archivo vinculado al archivo LNK.
            .DereferenceLinks = True
            ' Al igual que en VB6, utilice un conjunto de pares de filtros, separados por "|". Cada par consta de una especificación descripción|archivo. Utilice "|" entre los pares. No es necesario poner "|" al final. Puede establecer la propiedad FilterIndex también, para seleccionar el filtro predeterminado. El primer filtro tiene el número 1 (no 0). El valor predeterminado es 1. 
            .Filter = "Ficheros Access (*.txt)|*.txt|All files|*.*"
            .Multiselect = False
            ' ¿Restaurar el directorio original después de seleccionar un archivo? Si False, el directorio actual cambia al directorio en el que seleccionó el archivo. Establézcalo como True para poner la carpeta actual de nuevo donde estaba cuando comenzó. El valor predeterminado es False.
            .RestoreDirectory = True
            '¿Mostrar el botón Ayuda y la casilla de verificación Sólo lectura?
            .ShowHelp = True
            .ShowReadOnly = False
            ' ¿Comenzar con la casilla de verificación Sólo lectura activada?
            ' Esto sólo tiene sentido si ShowReadOnly es True.
            .ReadOnlyChecked = False
            .Title = "Seleccione fichero a restaurar"
            ' ¿Aceptar sólo nombres de archivo Win32 válidos?
            .ValidateNames = True
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Ruta = .FileName
            End If
        End With

        If Ruta <> "" Then
            Dim objReader As New StreamReader(Ruta)
            'Existen varias maneras de leer en el archivo, incluido el método ReadToEnd que lee en el archivo entero de una vez. Sin embargo, en este ejemplo, puede utilizar el método ReadLine para introducir el archivo línea a línea. Cuando se alcanza el final del archivo, este método devuelve "Nothing", lo que permite terminar el bucle. Mientras lee cada línea del archivo, puede usar el método Add de la ArrayList para insertar las líneas en la clase ArrayList.
            Do
                sLine = objReader.ReadLine()
                If Not sLine Is Nothing Then
                    arrText.Add(sLine)
                    TXTwriteText.Text += sLine & vbCrLf
                End If
            Loop Until sLine Is Nothing
            objReader.Close()
        End If

    End Sub
End Class
'metodo #2
'        TXTOutput.Text = ""
'        For a = 0 To TXTwriteText.Text.Length - 1
''MsgBox(Asc(Mid(TXTwriteText.Text, a + 1, 1)))
'            LBLproceced.Text = a.ToString & " of " & TXTwriteText.Text.Length - 1
'            TXTOutput.Text += AscCode(Asc(Mid(TXTwriteText.Text, a + 1, 1)))
'            If CHKplace_space.Checked = True Then TXTOutput.Text += " "
'        Next a
