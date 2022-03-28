//using Entities;
using DAL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using TrepupAPI.Models;

public class Common
{
    public Common()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #region Public Implementations

    public static string TLDs = "aaa|aarp|abarth|abb|abbott|abbvie|abc|able|abogado|abudhabi|ac|academy|accenture|accountant|accountants|aco|actor|ad|adac|ads|adult|ae|aeg|aero|aetna|af|afamilycompany|afl|africa|ag|agakhan|agency|ai|aig|airbus|airforce|airtel|akdn|al|alfaromeo|alibaba|alipay|allfinanz|allstate|ally|alsace|alstom|am|amazon|americanexpress|americanfamily|amex|amfam|amica|amsterdam|analytics|android|anquan|anz|ao|aol|apartments|app|apple|aq|aquarelle|ar|arab|aramco|archi|army|arpa|art|arte|as|asda|asia|associates|at|athleta|attorney|au|auction|audi|audible|audio|auspost|author|auto|autos|avianca|aw|aws|ax|axa|az|azure|ba|baby|baidu|banamex|bananarepublic|band|bank|bar|barcelona|barclaycard|barclays|barefoot|bargains|baseball|basketball|bauhaus|bayern|bb|bbc|bbt|bbva|bcg|bcn|bd|be|beats|beauty|beer|bentley|berlin|best|bestbuy|bet|bf|bg|bh|bharti|bi|bible|bid|bike|bing|bingo|bio|biz|bj|black|blackfriday|blockbuster|blog|bloomberg|blue|bm|bms|bmw|bn|bnpparibas|bo|boats|boehringer|bofa|bom|bond|boo|book|booking|bosch|bostik|boston|bot|boutique|box|br|bradesco|bridgestone|broadway|broker|brother|brussels|bs|bt|budapest|bugatti|build|builders|business|buy|buzz|bv|bw|by|bz|bzh|ca|cab|cafe|cal|call|calvinklein|cam|camera|camp|cancerresearch|canon|capetown|capital|capitalone|car|caravan|cards|care|career|careers|cars|casa|case|cash|casino|cat|catering|catholic|cba|cbn|cbre|cbs|cc|cd|center|ceo|cern|cf|cfa|cfd|cg|ch|chanel|channel|charity|chase|chat|cheap|chintai|christmas|chrome|church|ci|cipriani|circle|cisco|citadel|citi|citic|city|cityeats|ck|cl|claims|cleaning|click|clinic|clinique|clothing|cloud|club|clubmed|cm|cn|co|coach|codes|coffee|college|cologne|com|comcast|commbank|community|company|compare|computer|comsec|condos|construction|consulting|contact|contractors|cooking|cookingchannel|cool|coop|corsica|country|coupon|coupons|courses|cpa|cr|credit|creditcard|creditunion|cricket|crown|crs|cruise|cruises|csc|cu|cuisinella|cv|cw|cx|cy|cymru|cyou|cz|dabur|dad|dance|data|date|dating|datsun|day|dclk|dds|de|deal|dealer|deals|degree|delivery|dell|deloitte|delta|democrat|dental|dentist|desi|design|dev|dhl|diamonds|diet|digital|direct|directory|discount|discover|dish|diy|dj|dk|dm|dnp|do|docs|doctor|dog|domains|dot|download|drive|dtv|dubai|duck|dunlop|dupont|durban|dvag|dvr|dz|earth|eat|ec|eco|edeka|edu|education|ee|eg|email|emerck|energy|engineer|engineering|enterprises|epson|equipment|er|ericsson|erni|es|esq|estate|et|etisalat|eu|eurovision|eus|events|exchange|expert|exposed|express|extraspace|fage|fail|fairwinds|faith|family|fan|fans|farm|farmers|fashion|fast|fedex|feedback|ferrari|ferrero|fi|fiat|fidelity|fido|film|final|finance|financial|fire|firestone|firmdale|fish|fishing|fit|fitness|fj|fk|flickr|flights|flir|florist|flowers|fly|fm|fo|foo|food|foodnetwork|football|ford|forex|forsale|forum|foundation|fox|fr|free|fresenius|frl|frogans|frontdoor|frontier|ftr|fujitsu|fun|fund|furniture|futbol|fyi|ga|gal|gallery|gallo|gallup|game|games|gap|garden|gay|gb|gbiz|gd|gdn|ge|gea|gent|genting|george|gf|gg|ggee|gh|gi|gift|gifts|gives|giving|gl|glade|glass|gle|global|globo|gm|gmail|gmbh|gmo|gmx|gn|godaddy|gold|goldpoint|golf|goo|goodyear|goog|google|gop|got|gov|gp|gq|gr|grainger|graphics|gratis|green|gripe|grocery|group|gs|gt|gu|guardian|gucci|guge|guide|guitars|guru|gw|gy|hair|hamburg|hangout|haus|hbo|hdfc|hdfcbank|health|healthcare|help|helsinki|here|hermes|hgtv|hiphop|hisamitsu|hitachi|hiv|hk|hkt|hm|hn|hockey|holdings|holiday|homedepot|homegoods|homes|homesense|honda|horse|hospital|host|hosting|hot|hoteles|hotels|hotmail|house|how|hr|hsbc|ht|hu|hughes|hyatt|hyundai|ibm|icbc|ice|icu|id|ie|ieee|ifm|ikano|il|im|imamat|imdb|immo|immobilien|in|inc|industries|infiniti|info|ing|ink|institute|insurance|insure|int|international|intuit|investments|io|ipiranga|iq|ir|irish|is|ismaili|ist|istanbul|it|itau|itv|jaguar|java|jcb|je|jeep|jetzt|jewelry|jio|jll|jm|jmp|jnj|jo|jobs|joburg|jot|joy|jp|jpmorgan|jprs|juegos|juniper|kaufen|kddi|ke|kerryhotels|kerrylogistics|kerryproperties|kfh|kg|kh|ki|kia|kim|kinder|kindle|kitchen|kiwi|km|kn|koeln|komatsu|kosher|kp|kpmg|kpn|kr|krd|kred|kuokgroup|kw|ky|kyoto|kz|la|lacaixa|lamborghini|lamer|lancaster|lancia|land|landrover|lanxess|lasalle|lat|latino|latrobe|law|lawyer|lb|lc|lds|lease|leclerc|lefrak|legal|lego|lexus|lgbt|li|lidl|life|lifeinsurance|lifestyle|lighting|like|lilly|limited|limo|lincoln|linde|link|lipsy|live|living|lixil|lk|llc|llp|loan|loans|locker|locus|loft|lol|london|lotte|lotto|love|lpl|lplfinancial|lr|ls|lt|ltd|ltda|lu|lundbeck|luxe|luxury|lv|ly|ma|macys|madrid|maif|maison|makeup|man|management|mango|map|market|marketing|markets|marriott|marshalls|maserati|mattel|mba|mc|mckinsey|md|me|med|media|meet|melbourne|meme|memorial|men|menu|merckmsd|mg|mh|miami|microsoft|mil|mini|mint|mit|mitsubishi|mk|ml|mlb|mls|mm|mma|mn|mo|mobi|mobile|moda|moe|moi|mom|monash|money|monster|mormon|mortgage|moscow|moto|motorcycles|mov|movie|mp|mq|mr|ms|msd|mt|mtn|mtr|mu|museum|mutual|mv|mw|mx|my|mz|na|nab|nagoya|name|natura|navy|nba|nc|ne|nec|net|netbank|netflix|network|neustar|new|news|next|nextdirect|nexus|nf|nfl|ng|ngo|nhk|ni|nico|nike|nikon|ninja|nissan|nissay|nl|no|nokia|northwesternmutual|norton|now|nowruz|nowtv|np|nr|nra|nrw|ntt|nu|nyc|nz|obi|observer|off|office|okinawa|olayan|olayangroup|oldnavy|ollo|om|omega|one|ong|onl|online|ooo|open|oracle|orange|org|organic|origins|osaka|otsuka|ott|ovh|pa|page|panasonic|paris|pars|partners|parts|party|passagens|pay|pccw|pe|pet|pf|pfizer|pg|ph|pharmacy|phd|philips|phone|photo|photography|photos|physio|pics|pictet|pictures|pid|pin|ping|pink|pioneer|pizza|pk|pl|place|play|playstation|plumbing|plus|pm|pn|pnc|pohl|poker|politie|porn|post|pr|pramerica|praxi|press|prime|pro|prod|productions|prof|progressive|promo|properties|property|protection|pru|prudential|ps|pt|pub|pw|pwc|py|qa|qpon|quebec|quest|qvc|racing|radio|raid|re|read|realestate|realtor|realty|recipes|red|redstone|redumbrella|rehab|reise|reisen|reit|reliance|ren|rent|rentals|repair|report|republican|rest|restaurant|review|reviews|rexroth|rich|richardli|ricoh|ril|rio|rip|rmit|ro|rocher|rocks|rodeo|rogers|room|rs|rsvp|ru|rugby|ruhr|run|rw|rwe|ryukyu|sa|saarland|safe|safety|sakura|sale|salon|samsclub|samsung|sandvik|sandvikcoromant|sanofi|sap|sarl|sas|save|saxo|sb|sbi|sbs|sc|sca|scb|schaeffler|schmidt|scholarships|school|schule|schwarz|science|scjohnson|scot|sd|se|search|seat|secure|security|seek|select|sener|services|ses|seven|sew|sex|sexy|sfr|sg|sh|shangrila|sharp|shaw|shell|shia|shiksha|shoes|shop|shopping|shouji|show|showtime|si|silk|sina|singles|site|sj|sk|ski|skin|sky|skype|sl|sling|sm|smart|smile|sn|sncf|so|soccer|social|softbank|software|sohu|solar|solutions|song|sony|soy|spa|space|sport|spot|sr|srl|ss|st|stada|staples|star|statebank|statefarm|stc|stcgroup|stockholm|storage|store|stream|studio|study|style|su|sucks|supplies|supply|support|surf|surgery|suzuki|sv|swatch|swiftcover|swiss|sx|sy|sydney|systems|sz|tab|taipei|talk|taobao|target|tatamotors|tatar|tattoo|tax|taxi|tc|tci|td|tdk|team|tech|technology|tel|temasek|tennis|teva|tf|tg|th|thd|theater|theatre|tiaa|tickets|tienda|tiffany|tips|tires|tirol|tj|tjmaxx|tjx|tk|tkmaxx|tl|tm|tmall|tn|to|today|tokyo|tools|top|toray|toshiba|total|tours|town|toyota|toys|tr|trade|trading|training|travel|travelchannel|travelers|travelersinsurance|trust|trv|tt|tube|tui|tunes|tushu|tv|tvs|tw|tz|ua|ubank|ubs|ug|uk|unicom|university|uno|uol|ups|us|uy|uz|va|vacations|vana|vanguard|vc|ve|vegas|ventures|verisign|versicherung|vet|vg|vi|viajes|video|vig|viking|villas|vin|vip|virgin|visa|vision|viva|vivo|vlaanderen|vn|vodka|volkswagen|volvo|vote|voting|voto|voyage|vu|vuelos|wales|walmart|walter|wang|wanggou|watch|watches|weather|weatherchannel|webcam|weber|website|wed|wedding|weibo|weir|wf|whoswho|wien|wiki|williamhill|win|windows|wine|winners|wme|wolterskluwer|woodside|work|works|world|wow|ws|wtc|wtf|xbox|xerox|xfinity|xihuan|xin|xxx|xyz|yachts|yahoo|yamaxun|yandex|ye|yodobashi|yoga|yokohama|you|youtube|yt|yun|za|zappos|zara|zero|zip|zm|zone|zuerich|zw";

    public static bool IsValidDataSet(DataSet dsToValidate)
    {
        bool isValid = false;
        if (dsToValidate != null)
        {
            foreach (DataTable dt in dsToValidate.Tables)
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
        }
        return isValid;
    }

    public static bool IsValidDataTable(DataTable dtToValidate)
    {
        bool isValid = false;
        if (dtToValidate != null && dtToValidate.Rows.Count > 0)
        {
            isValid = true;
        }
        else
        {
            isValid = false;
        }

        return isValid;
    }

    public static bool IsValidList<T>(List<T> lstObj)
    {
        bool result = false;

        if (lstObj != null && lstObj.Count > 0)
        {
            result = true;
        }
        return result;
    }

    public static string DataTableToJSON(DataTable table) //TBC: User Review Change
    {
        List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();

        foreach (DataRow row in table.Rows)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();

            foreach (DataColumn col in table.Columns)
            {
                dict[col.ColumnName] = row[col];
            }
            list.Add(dict);
        }

        return JsonConvert.SerializeObject(list, new IsoDateTimeConverter());
    }

    public static string RemoveSpecialChars(string text)
    {
        //string abc  = " AæA!A\"A#A$A%A&A'A(A)A*A+A,A-A.A/A:A;A<A=A>A?A@A^A]A[A_A`A{A|A}A~A€A‚AƒA„A…A†A‡AˆA‰AŠA‹AŒAŽA‘A’A“A”A•A–A—A~A™AšA›AœAžAŸA¡A¢A£A¥A|A§A¨A©AªA«A¬A¯A®A¯A°A±A²A³A´AµA¶A·A¸A¹AºA»A¼A½A¾A¿AÀAÁAÂAÃAÄAÅAÆAÇAÈAÉAÊAËAÌAÍAÎAÏAÐAÑAÒAÓAÔAÕAÖAØAÙAÚAÛAÜAÝAÞAßAàAáAâAãAäAåAæAçAèAéAêAëAìAíAîAïAðAñAòAóAôAõAöA÷AøAùAúAûAüAýAþAÿ" ;
        //string[] specialChars = abc.Split('A');
        //string[] specialChars = new string[153] { " ", "æ", "!", "\"", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", ":", ";", "<", "=", ">", "?", "@", "^", "]", "[", "_", "`", "{", "|", "}", "~", "€", "‚", "ƒ", "„", "…", "†", "‡", "ˆ", "‰", "Š", "‹", "Œ", "Ž", "‘", "’", "“", "”", "•", "–", "—", "~", "™", "š", "›", "œ", "ž", "Ÿ", "¡", "¢", "£", "¥", "|", "§", "¨", "©", "ª", "«", "¬", "¯", "®", "¯", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "»", "¼", "½", "¾", "¿", "À", "Á", "Â", "Ã", "Ä", "Å", "Æ", "Ç", "È", "É", "Ê", "Ë", "Ì", "Í", "Î", "Ï", "Ð", "Ñ", "Ò", "Ó", "Ô", "Õ", "Ö", "Ø", "Ù", "Ú", "Û", "Ü", "Ý", "Þ", "ß", "à", "á", "â", "ã", "ä", "å", "æ", "ç", "è", "é", "ê", "ë", "ì", "í", "î", "ï", "ð", "ñ", "ò", "ó", "ô", "õ", "ö", "÷", "ø", "ù", "ú", "û", "ü", "ý", "þ", "ÿ" };
        string[] specialChars = new string[153] { ":", "æ", "!", "\\", "\"", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", ";", "<", "=", ">", "?", "@", "^", "]", "[", "_", "`", "{", "|", "}", "~", "€", "‚", "ƒ", "„", "…", "†", "‡", "ˆ", "‰", "Š", "‹", "Œ", "Ž", "‘", "’", "“", "”", "•", "–", "—", "~", "™", "š", "›", "œ", "ž", "Ÿ", "¡", "¢", "£", "¥", "|", "§", "¨", "©", "ª", "«", "¬", "¯", "®", "¯", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "»", "¼", "½", "¾", "¿", "À", "Á", "Â", "Ã", "Ä", "Å", "Æ", "Ç", "È", "É", "Ê", "Ë", "Ì", "Í", "Î", "Ï", "Ð", "Ñ", "Ò", "Ó", "Ô", "Õ", "Ö", "Ø", "Ù", "Ú", "Û", "Ü", "Ý", "Þ", "ß", "à", "á", "â", "ã", "ä", "å", "æ", "ç", "è", "é", "ê", "ë", "ì", "í", "î", "ï", "ð", "ñ", "ò", "ó", "ô", "õ", "ö", "÷", "ø", "ù", "ú", "û", "ü", "ý", "þ", "ÿ" };

        for (int i = 0; i < specialChars.Length; i++)
        {
            text = text.Replace(specialChars[i], " ");
        }
        text = Regex.Replace(text, "[ ]{2,}", " ", RegexOptions.None).Trim();
        return text;
    }

    public static string GetImageFormat(System.Drawing.Image img)
    {


        if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
            return "jpg";
        if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp))
            return "bmp";
        if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
            return "png";
        if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Emf))
            return "emf";
        if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Exif))
            return "exif";

        if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
            return "gif";
        if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Icon))
            return "icon";
        if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.MemoryBmp))
            return "memorybmp";
        if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Tiff))
            return "tiff";
        else
            return "jpg";
    }

    public static bool IsValidUri(string uri)
    {
        Uri result;
        return Uri.TryCreate(uri, UriKind.Absolute, out result);
    }

    public static string ShowTime(DateTime UTCDateTime, bool IsSinglePageFormat = false)
    {
        string timeFormat = "";
        TimeSpan dateDiff = DateTime.UtcNow.Subtract(UTCDateTime);
        if (dateDiff.TotalSeconds < 60)
        {
            timeFormat = "Now";
        }
        else if (dateDiff.TotalMinutes < 60)
        {
            timeFormat = GetPreDotValue(dateDiff.TotalMinutes) + "m";
            if (IsSinglePageFormat)
            {
                timeFormat = "Posted " + GetPreDotValue(dateDiff.TotalMinutes) + (Convert.ToDouble(GetPreDotValue(dateDiff.TotalMinutes)) > 1 ? " minutes ago" : "minute ago");
            }
        }
        else if (dateDiff.TotalHours < 24)
        {
            timeFormat = GetPreDotValue(dateDiff.TotalHours) + "h";
            if (IsSinglePageFormat)
            {
                timeFormat = "Posted " + GetPreDotValue(dateDiff.TotalHours) + (Convert.ToDouble(GetPreDotValue(dateDiff.TotalHours)) > 1 ? " hours ago" : "hour ago");
            }
        }
        else if (dateDiff.TotalDays < 7)
        {
            timeFormat = GetPreDotValue(dateDiff.TotalDays) + "d";
            if (IsSinglePageFormat)
            {
                timeFormat = "Posted " + GetPreDotValue(dateDiff.TotalDays) + (Convert.ToDouble(GetPreDotValue(dateDiff.TotalDays)) > 1 ? " days ago" : "day ago");
            }
        }
        else if (((dateDiff.TotalDays) / 7) < 52)
        {
            timeFormat = GetPreDotValue((dateDiff.TotalDays) / 7) + "w";
            if (IsSinglePageFormat)
            {
                timeFormat = "Posted " + GetPreDotValue((dateDiff.TotalDays) / 7) + (Convert.ToDouble(GetPreDotValue((dateDiff.TotalDays) / 7)) > 1 ? " weeks ago" : "week ago");
            }
        }
        else
        {
            timeFormat = GetPreDotValue((dateDiff.TotalDays) / 365) + "y";
            if (IsSinglePageFormat)
            {
                timeFormat = "Posted " + GetPreDotValue((dateDiff.TotalDays) / 365) + (Convert.ToDouble(GetPreDotValue((dateDiff.TotalDays) / 365)) > 1 ? " years ago" : "year ago");
            }
        }
        return timeFormat.TrimStart('0');
    }

    public static string GetPreDotValue(double value)
    {
        if (value.ToString().IndexOf(".") >= 0)
        {
            string val = Convert.ToString(value).Substring(0, Convert.ToString(value).IndexOf("."));
            if (val == "0")
            {
                val = "1";
            }
            return val;
        }
        else
        {
            return Convert.ToString(value);
        }
    }

    //New ConvertToUrl function for url & links
    public static ArrayList ConvertUrlsToLinks(string rawString)
    {
        try
        {
            string[] temp4;
            //char[] whitespace = new char[] { ' ', '\t', ' ', '\r'};
            //rawString = rawString.Replace("\n", "<br/>");
            char[] whitespace = new char[] { ' ', '\t', ' ', '\r' };
            string[] temp3 = rawString.Split(whitespace);
            ArrayList al = new ArrayList();
            string replacePattern1, replacePattern2, replacePattern3, replacePattern6, replacePattern7, replacePattern8, replacePattern10;
            replacePattern1 = @"^([a-zA-Z0-9]|http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/|www\.|[a-zA-Z0-9])[a-zA-Z0-9]+([\-\.]{1}[a-zA-Z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$";

            replacePattern2 = @"\A(?:[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?)\Z";

            replacePattern8 = @"\b^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)\b";//only http(s)

            replacePattern3 = @"(([a-zA-Z0-9\.])+@[a-zA-Z]+?(\.[" + TLDs + @"]{2,6})|^[@./#&+-:]\s+)";//@gmail.co.in
            replacePattern6 = @"(((http|https|ftp|news|file)+\:\/\/|(www\.)|[a-z0-9])[_.a-z0-9-]+\.[a-z0-9\/_:@=.+?,##%&~-]*[^.|\'|\# |!|\(|?|,| |>|<|;|\)]|^[@./#&+-:]\s+)";
            replacePattern10 = @"([\d\w-.]+?\.(a[cdefgilmnoqrstuwz]|b[abdefghijmnorstvwyz]|c[acdfghiklmnoruvxyz]|d[ejkmnoz]|e[ceghrst]|f[ijkmnor]|g[abdefghilmnpqrstuwy]|h[kmnrtu]|i[delmnoqrst]|j[emop]|k[eghimnprwyz]|l[abcikrstuvy]|m[acdghklmnopqrstuvwxyz]|n[acefgilopruz]|om|p[aefghklmnrstwy]|qa|r[eouw]|s[abcdeghijklmnortuvyz]|t[cdfghjkmnoprtvwz]|u[augkmsyz]|v[aceginu]|w[fs]|y[etu]|z[amw]|aero|arpa|biz|com|coop|edu|info|int|gov|mil|museum|name|net|org|pro)(\b|\W(?<!&|=)(?!\.\s|\.{3}).*?))(\s|$)";
            replacePattern7 = @"(((http|https|ftp|news|file)+\:\/\/|(www\.)[^a-z0-9])[_.a-z0-9-]+\.[a-z0-9\/_:@=.+?,##%&~-]*[^.|\'|\# |!|\(|?|,| |>|<|;|\)]([\S]*)|^[@./#&+-:])";
            Regex r = new Regex(replacePattern3, RegexOptions.IgnoreCase);
            Regex r1 = new Regex(replacePattern6, RegexOptions.IgnoreCase);
            Regex r2 = new Regex(replacePattern7, RegexOptions.IgnoreCase);

            foreach (string s in temp3)
            {
                if (Regex.IsMatch(s, "^[a-zA-Z0-9:\x20]+$"))
                { al.Add(s); }
                else if (Regex.IsMatch(s, replacePattern1))
                {
                    if (!Regex.IsMatch(s, replacePattern8))
                    {
                        if (Regex.IsMatch(s, replacePattern10))
                        {
                            rawString = s.Replace(s, "<a target='_blank' class='changeLink' href='http://" + s + "' rel='nofollow noopener noreferrer'>" + s + "</a>");
                            al.Add(rawString);
                        }
                        else
                        { al.Add(s); }
                    }
                    else if (Regex.IsMatch(s, replacePattern8))
                    {
                        rawString = s.Replace(s, "<a target='_blank' class='changeLink' href='" + s + "' rel='nofollow noopener noreferrer'>" + s + "</a>");
                        al.Add(rawString);
                    }
                    else
                    { al.Add(s); }
                }
                else if (Regex.IsMatch(s, replacePattern2))
                {
                    if ((!s.Contains("www.")) && (s.Contains("@")))
                    {
                        rawString = s.Replace(s, "<a class='changeLink' href='mailto:" + s + "' rel='nofollow noopener noreferrer'>" + s + "</a>");
                        al.Add(rawString);
                    }
                }
                else if (Regex.IsMatch(s, replacePattern3) && (!Regex.IsMatch(s, @"[0-9]\.")))
                {

                    if (Regex.IsMatch(s, replacePattern2))
                    {
                        temp4 = Regex.Split(s, replacePattern3);
                        if (Regex.IsMatch(temp4[1] + temp4[4], replacePattern2))
                        {
                            if ((!Regex.IsMatch(s, @"^[:\/:#]")))
                            {
                                rawString = s.Replace(s, temp4[0] + "<a class='changeLink' href='mailto:" + temp4[1] + temp4[4] + "' rel='nofollow noopener noreferrer'>" + temp4[1] + temp4[4] + "</a>");
                                al.Add(rawString);
                            }
                            else
                            { al.Add(s); }
                        }
                        else
                        { al.Add(s); }
                    }
                    else if ((!Regex.IsMatch(s, @"^[:\/:#]")))
                    {
                        temp4 = Regex.Split(s, replacePattern3);
                        if (temp4.Length == 5 || temp4.Length == 6)
                        {
                            if (Regex.IsMatch(temp4[1] + temp4[4], replacePattern2))
                            {
                                rawString = s.Replace(s, temp4[0] + "<a class='changeLink' href='mailto:" + temp4[1] + temp4[4] + "' rel='nofollow noopener noreferrer'>" + temp4[1] + temp4[4] + "</a>");
                                al.Add(rawString);
                            }
                            else
                            { al.Add(s); }
                        }
                        else
                        { al.Add(s); }
                    }
                    else
                    { al.Add(s); }

                }
                else if (Regex.IsMatch(s, replacePattern6))
                {
                    temp4 = Regex.Split(s, replacePattern6, RegexOptions.IgnoreCase);
                    if ((!s.ToLower().Contains("localhost:")))
                    {
                        if (temp4.Length == 5 || temp4.Length == 6)
                        {
                            if (Regex.IsMatch(temp4[1] + temp4[4], replacePattern1, RegexOptions.IgnoreCase))
                            {
                                if ((s.Contains("http://")) || (s.Contains("https://")))
                                {
                                    if (Regex.IsMatch(s, replacePattern10))
                                    {
                                        rawString = s.Replace(s, temp4[0] + "<a target='_blank' class='changeLink' href='" + temp4[1] + temp4[4] + "' rel='nofollow noopener noreferrer'>" + temp4[1] + temp4[4] + "</a>");
                                        al.Add(rawString);
                                    }
                                    else
                                    { al.Add(s); }
                                }
                                else
                                {
                                    if (Regex.IsMatch(s, replacePattern10))
                                    {
                                        rawString = s.Replace(s, temp4[0] + "<a target='_blank' class='changeLink' href='http://" + temp4[1] + temp4[4] + "' rel='nofollow noopener noreferrer'>" + temp4[1] + temp4[4] + "</a>");
                                        al.Add(rawString);
                                    }
                                    else
                                    { al.Add(s); }
                                }
                            }
                            else
                            { al.Add(s); }
                        }
                        else if (temp4.Length < 5)
                        {
                            if (Regex.IsMatch(temp4[1], replacePattern1, RegexOptions.IgnoreCase))
                            {
                                if ((s.Contains("http://")) || (s.Contains("https://")))
                                {
                                    if (Regex.IsMatch(s, replacePattern10))
                                    {
                                        rawString = s.Replace(s, temp4[0] + "<a target='_blank' class='changeLink' href='" + temp4[1] + "' rel='nofollow noopener noreferrer'>" + temp4[1] + "</a>");
                                        al.Add(rawString);
                                    }
                                    else
                                    { al.Add(s); }
                                }
                                else
                                {
                                    if (Regex.IsMatch(s, replacePattern10))
                                    {
                                        rawString = s.Replace(s, temp4[0] + "<a target='_blank' class='changeLink' href='http://" + temp4[1] + "' rel='nofollow noopener noreferrer'>" + temp4[1] + "</a>");
                                        al.Add(rawString);
                                    }
                                    else
                                    { al.Add(s); }
                                }
                            }
                            else
                            { al.Add(s); }
                        }
                        else
                        { al.Add(s); }
                    }
                    else
                    { al.Add(s); }
                }
                else
                {
                    al.Add(s);
                }
            }
            return al;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static int CountStringOccurrences(string text, string pattern)
    {
        int count = 0;
        int i = 0;
        while ((i = text.IndexOf(pattern, i)) != -1)
        {
            i += pattern.Length;
            count++;
        }
        return count;
    }

    public static string GetHtmlUsingWebResponse(string href)
    {
        string result = null;
        WebResponse response = default(WebResponse);
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(href);
        try
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.84 Safari/537.36";
            request.Timeout = 3600000;
            response = request.GetResponse();
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                result = sr.ReadToEnd();
                sr.Close();
            }
        }
        catch (Exception)
        {
            result = "";
        }
        finally
        {
            response = null;
            request = null;
        }
        return result;
    }

    /// <summary>
    /// get resoponse from web request with POST method
    /// </summary>
    /// <param name="href"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public static string GetResonseFromUrlPostRequest(string href, string parameters)
    {
        //HttpClient client = new HttpClient();

        //var content = new FormUrlEncodedContent(dictPostValues);

        //var response = await client.PostAsync(href, content);

        //var responseString = await response.Content.ReadAsStringAsync();

        //return responseString;


        string result = null;
        try
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            // Create a request using a URL that can receive a post.   
            WebRequest request = WebRequest.Create(href);
            // Set the Method property of the request to POST.  
            request.Method = "POST";

            // Create POST data and convert it to a byte array.  
            byte[] byteArray = Encoding.UTF8.GetBytes(parameters);

            // Set the ContentType property of the WebRequest.  
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.  
            request.ContentLength = byteArray.Length;

            // Get the request stream.  
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.  
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.  
            dataStream.Close();

            // Get the response.  
            WebResponse response = request.GetResponse();
            //// Display the status.  
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.  
            // The using block ensures the stream is automatically closed.
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                //// Open the stream using a StreamReader for easy access.  
                //StreamReader reader = new StreamReader(sr);
                // Read the content.  
                result = sr.ReadToEnd();
            }

            request = null;
            // Close the response.  
            response.Close();
        }
        catch (Exception)
        {
            result = "";
        }
        return result;
    }

    public static string TruncateIncludeHTML(string input, int length)
    {
        input = input.Replace("<br />", "\n").Replace("<br/>", "\n");
        if (input.Length <= length)
        {
            return input;
        }
        else
        {
            string cutted = input.Substring(0, length);
            cutted = cutted.TrimEnd();
            string[] arrayCutted = cutted.Split(' ');
            if (arrayCutted[arrayCutted.Length - 1].StartsWith("#"))
            {
                int lastIndexOfCutted = cutted.LastIndexOf(" ") + 1;
                string fullWordCuttedEnd = input.Substring(lastIndexOfCutted).Split(' ')[0];
                arrayCutted[arrayCutted.Length - 1] = fullWordCuttedEnd;
                cutted = string.Join(" ", arrayCutted);
                cutted = cutted.TrimEnd();
            }
            try
            {
                // if theres no tags, we can just stop it here.
                if (cutted.IndexOf('<') == -1) { return RemoveAllLastSpecialCharater(cutted).Replace("\n", "<br />") + "..."; }
                int balance = 0;
                //check the truncated(cutted) string for unclosed tags
                for (int i = 0; i < cutted.Length; i++)
                {
                    // if the index location is a tag opening
                    if (cutted[i] == '<')
                    {
                        balance++;
                    }
                    // else if the index location is '/' and right after there's a '>' or one before is a '<' <img ../> or <p>..</p>
                    else if ((cutted[i] == '/'))
                    {
                        if ((i + 1) < cutted.Length)
                        {
                            if (((cutted[i + 1] == '>') || (cutted[i - 1] == '<')))
                            {
                                balance--;
                                if (cutted[i + 1] == 'a')
                                {
                                    balance--;
                                }
                            }
                        }
                    }
                }
                //if there isn't a closing for each opening of a tag
                //assuming there will never be a string that starts with a closing of a tag
                //(data is filtered and formatted before saving to the data base)
                //ignoring negative values aswel as neutral value
                if (balance > 0)
                {
                    int cutUntil = 0;
                    // foreach unclosed tag we found in the truncated string
                    for (int i = 0; i < balance; i++)
                    {
                        // check to see which is the closest closing of a tag "/>" or "</"
                        // assuming that every tag as a closing in the original string
                        //(data is filtered and formatted before saving to the data base)
                        // if "/>" is the closest (e.g. <img .... />)
                        if ((input.IndexOf("/>", cutted.Length)) > (input.IndexOf("</", cutted.Length)))
                        {
                            // get the index location in the original string where "/>" found, +2 is to include the "/>"
                            cutUntil = input.IndexOf("/>", cutted.Length) + 2;
                        }
                        // else the tag ends with a "</..>" (e.g. <a href="...">...</a>)
                        else
                        {
                            // get the index location in the original string of the next ">" after "</"
                            cutUntil = input.IndexOf(">", input.IndexOf("</", cutted.Length)) + 1;
                        }
                        // given the index location of the closing tag, add a string from the original string the includes the closure
                        // add a piece of the original string from the ending (we had unclosed tags, it must be after the truncated string)
                        // and add the number of indexes that is the diffrence between the absolute location on the closing tag
                        // and the length of what we have already.
                        string add = input.Substring(cutted.Length, (cutUntil - cutted.Length));
                        cutted += add;
                        // before going to the next loop we must check if we added new tags in the proccess
                        if (add.IndexOf('<') == -1) { continue; }
                        // if we got here, we have new tags to consider..
                        for (int j = 0; j < add.Length; j++)
                        {
                            // if the index location is a tag opening
                            if (add[j] == '<')
                            {
                                balance++;
                            }
                            // else if the index location is '/' and right after there's a '>' or one before is a '<' <img ../> or <p>..</p>
                            else if ((add[j] == '/') && ((add[j + 1] == '>') || (add[j - 1] == '<')))
                            {
                                balance--;
                            }
                        }
                        // once this is done, go for the next loop with the new, longer truncated string.
                    }
                }


                if (cutted[cutted.Length - 1] == 'a' && cutted[cutted.Length - 2] == '/' && cutted[cutted.Length - 3] == '<')
                {
                    cutted = cutted + ">";
                }

                if (cutted.Length == input.Length)
                {
                    cutted = cutted.Replace("\n", "<br />");
                }
                else
                {
                    cutted = RemoveAllLastSpecialCharater(cutted).Replace("\n", "<br />") + "...";
                }

                return cutted;
            }
            catch (Exception)
            {
                if (cutted[cutted.Length - 1] == 'a' && cutted[cutted.Length - 2] == '/' && cutted[cutted.Length - 3] == '<')
                {
                    cutted = cutted + ">";
                }
                else if (cutted[cutted.Length - 1] == '/' && cutted[cutted.Length - 2] == '<')
                {
                    cutted = cutted + "a>";
                }
                if (cutted.Length == input.Length)
                {
                    cutted = cutted.Replace("\n", "<br />");
                }
                else
                {
                    cutted = RemoveAllLastSpecialCharater(cutted).Replace("\n", "<br />") + "...";
                }

                return cutted;
            }

        }


    }

    public static string RemoveAllLastSpecialCharater(string inputText)
    {
        string prevVal = inputText;
        inputText = inputText.Trim();
        char[] arrSpecialCharacters = { ' ', '`', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=', '|', '\\', '}', ']', '{', '[', '\'', '"', ':', ';', '?', '/', '>', '.', '<', ',' };
        bool isChanged = false;
        int inputLengthBeforeProcess = inputText.Length;
        do
        {
            isChanged = false;
            inputLengthBeforeProcess = inputText.Length;
            foreach (char strSpecialChar in arrSpecialCharacters)
            {
                if (inputText.Length == 0)
                {
                    break;
                }
                else if (inputText[inputText.Length - 1] == '>' && inputText[inputText.Length - 2].ToString().ToLower() == "a" && inputText[inputText.Length - 3] == '/' && inputText[inputText.Length - 4] == '<')
                {
                    break;
                }
                else
                {
                    inputText = inputText.TrimEnd(strSpecialChar);
                }
            }

            if (inputText.Length == inputLengthBeforeProcess || inputText.Length == 0) { isChanged = false; } else { isChanged = true; }

        } while (isChanged);
        return inputText;
    }

    public static string MakeSingleBreakTag(string input)
    {
        string finalOutput = "";
        input = input.Replace("<br/>", "<br />").Replace("<br>", "<br />");
        string[] arrayCurrentInput = input.Split(new string[] { "<br />" }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string currentText in arrayCurrentInput)
        {
            if (currentText.Trim() != "")
            {
                finalOutput += currentText + "<br />";
            }
        }

        while (finalOutput.EndsWith("<br />"))
        {
            finalOutput = finalOutput.Substring(0, finalOutput.Length - 6);
        }

        return finalOutput;
    }

    public static string RandomDigit(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max).ToString("000000000");
    }

    public static bool IsValidEmail(string inputEmail)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(inputEmail);
            return true;
        }
        catch
        {
            return false;
        }
    }


    public static string RemoveDotInEmail(string inputEmail)
    {
        string Email = string.Empty;
        if (IsValidEmail(inputEmail))
        {
            if (inputEmail.Split('@')[0].ToString().Contains("."))
            {
                Email = inputEmail.Split('@')[0].ToString().Replace(".", "") + "@" + inputEmail.Split('@')[1].ToString();
            }
            else
            {
                Email = inputEmail;
            }
        }

        return Email;
    }

    /// <summary>
    /// to validate email from contacts
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    public static bool IsValidContactEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        try
        {
            // Normalize the domain
            email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                  RegexOptions.None, TimeSpan.FromMilliseconds(200));


        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
        catch (ArgumentException)
        {
            return false;
        }

        try
        {
            if (email.Split('@')[0].Length > 64)
                return false;

            return Regex.IsMatch(email,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }

    // Examines the domain part of the email and normalizes it.
    public static string DomainMapper(Match match)
    {
        // Use IdnMapping class to convert Unicode domain names.
        var idn = new IdnMapping();

        // Pull out and process domain name (throws ArgumentException on invalid)
        var domainName = idn.GetAscii(match.Groups[2].Value);

        return match.Groups[1].Value + domainName;
    }

    public static long RandomNumber()
    {
        Random random = new Random();
        long randomNumber = random.Next(100000, 999999);
        return randomNumber;
    }


    #region Long Random number for username
    public static string RandomDigit(int max)
    {
        Random random = new Random();
        string randNumber = Guid.NewGuid().ToString();
        byte[] asciiBytes = Encoding.ASCII.GetBytes(randNumber);
        randNumber = string.Join("", asciiBytes.ToArray());
        randNumber = new string(randNumber.ToCharArray().OrderBy(s => (random.Next(2) % 2) == 0).ToArray());
        randNumber = randNumber.Length < max ? randNumber : randNumber.Substring(0, max);
        asciiBytes = null;
        random = null;
        return randNumber;
    }
    #endregion

    #endregion

    public static Boolean HasSpecialCharacters(string text)
    {
        return !(new Regex("^[a-zA-Z0-9 ]*$").IsMatch(text));
    }

    public static string MakeSingleWhiteSpace(string input)
    {
        try
        {
            Regex regex = new Regex("[ ]{2,}", RegexOptions.None);
            input = regex.Replace(input, " ").Trim();
            regex = null;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return input;
    }

    public static string MakeSingleSpecialCharacter(string input, string specialChar)
    {
        try
        {
            Regex regex = new Regex("[" + specialChar + "]{2,}", RegexOptions.None);
            input = regex.Replace(input, specialChar).Trim();
            regex = null;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return input;
    }

    public static string FirstCharToUpper(string s)
    {
        // Check for empty string.
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        // Return char and concat substring.
        return char.ToUpper(s[0]) + s.Substring(1);
    }

    public static string ReplaceInsensitive(string str, string from, string to)
    {
        str = Regex.Replace(str, from, to, RegexOptions.IgnoreCase);
        return str;
    }

    public static string ReplaceSpecialCharacter(string text)
    {
        text = text.Replace("'", "");
        text = text.Replace("’", "");
        text = Regex.Replace(text, @"[^0-9a-zA-Z ]+", " ");
        Regex regex = new Regex("[ ]{2,}", RegexOptions.None);
        text = regex.Replace(text, " ").Trim();
        return text;
    }

    public static string ReplaceSpecialCharacterWithoutHash(string text)
    {
        text = text.Replace("'", "");
        text = text.Replace("’", "");
        text = Regex.Replace(text, @"[^0-9a-zA-Z# ]+", " ");
        text = text.Replace("# ", " ");
        text = text.Replace("#", "_");
        Regex regex = new Regex("[ ]{2,}", RegexOptions.None);
        text = regex.Replace(text, " ").Trim();
        return text;
    }

    /// <summary>
    /// replace special character and spaces with hypens for single page post url
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string UrlCompatibleString(string text)
    {
        string finalURL = "";
        if (text.Trim() != null && text.Trim() != "")
        {
            text = text.ToLower().Replace("'", "").Replace("’", "");
            char[] arrayChar = text.ToCharArray();
            foreach (char c in arrayChar)
            {
                if (char.IsLetterOrDigit(c) || char.GetUnicodeCategory(c) == UnicodeCategory.SpacingCombiningMark || char.GetUnicodeCategory(c) == UnicodeCategory.NonSpacingMark)
                {
                    finalURL += Convert.ToString(c);
                }
                else
                {
                    finalURL += "-";
                }
            }
            Regex regex = new Regex("[-]{2,}", RegexOptions.None);
            finalURL = regex.Replace(finalURL, "-").Trim('-');
        }
        return finalURL;
    }
    public static void AddPageLinks(string path, Page page, string type)
    {

        switch (type.ToLower())
        {
            case "css":
                HtmlLink oCss = new HtmlLink();
                oCss.Href = path;
                oCss.Attributes.Add("rel", "stylesheet");
                oCss.Attributes.Add("type", "text/css");
                page.Header.Controls.Add(oCss);
                oCss.Dispose();
                break;
            case "js":
                HtmlLink oJS = new HtmlLink();
                oJS.Href = path;
                oJS.Attributes.Add("type", "text/javascript");
                page.Header.Controls.Add(oJS);
                oJS.Dispose();
                break;
            case "schema":
                HtmlGenericControl oSchema = new HtmlGenericControl();
                oSchema.InnerHtml = path;
                oSchema.TagName = "script";
                oSchema.Attributes.Add("type", "application/ld+json");
                page.Header.Controls.Add(oSchema);
                oSchema.Dispose();
                break;
            case "canonical":
                HtmlLink oCanonical = new HtmlLink();
                oCanonical.Href = path;
                oCanonical.Attributes.Add("rel", "canonical");
                page.Header.Controls.Add(oCanonical);
                oCanonical.Dispose();
                break;
            case "alternate":
                HtmlLink oAlternate = new HtmlLink();
                oAlternate.Href = path;
                oAlternate.Attributes.Add("rel", "alternate");
                oAlternate.Attributes.Add("media", "only screen and (max-width: 640px)");
                page.Header.Controls.Add(oAlternate);
                oAlternate.Dispose();
                break;
        }

    }

    public static string CleanString(string dirtyString)
    {
        dirtyString = Regex.Replace(dirtyString, "[^a-zA-Z0-9.]", " ");
        string[] SplitArray = dirtyString.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string cleanString = String.Join(" ", SplitArray);
        return cleanString;
    }

    public static bool IsValidURLReferrer(Uri urlReferrer)
    {
        bool result = false;
        if (urlReferrer == null)
        {
            result = false;
        }
        else if (Convert.ToString(urlReferrer).ToLower().StartsWith(Convert.ToString(ConfigurationManager.AppSettings["WebsitePath"]).ToLower()) ||
                 Convert.ToString(urlReferrer).ToLower().StartsWith(Convert.ToString(ConfigurationManager.AppSettings["WebsitePath2"]).ToLower()) ||
                 Convert.ToString(urlReferrer).ToLower().StartsWith(Convert.ToString(ConfigurationManager.AppSettings["TrepmailPath"]).ToLower()))
        {
            result = true;
        }

        return result;
    }

    public static string FTSSanitizer(string text)
    {
        text = text.Trim();
        if (text == "") { return text; }
        return text.Replace("\"", "").Replace("'", "''").Replace("*", "").Replace("~", "");
    }

    public class Status
    {
        public int code;
        public string message;
    }

    public enum ResponseStatusSocialLogin
    {
        Facebook = 2,
        Google = 3
    }

    public class socialFBLogin : Status
    {
        public int statusCode()
        {
            code = 4;
            return code;
        }

        public string statusMessage()
        {
            message = "Facebook login successful";
            return message;
        }
    }
    public class socialGoogleLogin : Status
    {
        public int statusCode()
        {
            code = 5;
            return code;
        }

        public string statusMessage()
        {
            message = "Google login successful";
            return message;
        }
    }

    public class socialSignUp : Status
    {
        public int statusCode()
        {
            code = 7;
            return code;
        }

        public string statusMessage()
        {
            message = "Sign up successful";
            return message;
        }
    }
    public class socialFBSignUp : Status
    {
        public int statusCode()
        {
            code = 8;
            return code;
        }

        public string statusMessage()
        {
            message = "Facebook sign up successful";
            return message;
        }
    }
    public class socialGoogleSignUp : Status
    {
        public int statusCode()
        {
            code = 9;
            return code;
        }

        public string statusMessage()
        {
            message = "Google sign up successful";
            return message;
        }
    }

    public class socialInvalid : Status
    {
        public int statusCode()
        {
            code = 11;
            return code;
        }

        public string statusMessage()
        {
            message = "Invalid social account";
            return message;
        }
    }

    #region MobileDeviceDetation

    public static bool IsTouchDevice()
    {
        bool IsTouchDevice = false;
        HttpContext context = HttpContext.Current;
        try
        {
            if (context.Request.Browser.IsMobileDevice)
            {
                if (context.Request.ServerVariables["HTTP_USER_AGENT"] != null)
                {
                    IsTouchDevice = true;
                }
            }
            string getCurrentUserAgent = context.Request.UserAgent;
            if (getCurrentUserAgent != "")
            {
                //to check device has mobile, tablet, kindle
                if (getCurrentUserAgent.ToLower().Contains("android") || getCurrentUserAgent.ToLower().Contains("mobile") || getCurrentUserAgent.ToLower().Contains("tablet") || getCurrentUserAgent.ToLower().Contains("silk"))
                {
                    IsTouchDevice = true;
                }
            }
        }
        catch (Exception)
        {
            IsTouchDevice = false;
        }
        return IsTouchDevice;

    }

    public static void IsMobileBrowser()
    {
        bool IsMobileDevice = false;
        HttpContext context = HttpContext.Current;
        try
        {
            if (context.Request.Browser.IsMobileDevice)
            {
                if (context.Request.ServerVariables["HTTP_USER_AGENT"] != null)
                {
                    IsMobileDevice = true;
                }
            }
            string getCurrentUserAgent = context.Request.UserAgent;
            if (getCurrentUserAgent != "")
            {
                if (getCurrentUserAgent.ToLower().Contains("android") || getCurrentUserAgent.ToLower().Contains("mobile") || getCurrentUserAgent.ToLower().Contains("tablet") || getCurrentUserAgent.ToLower().Contains("silk"))
                {
                    IsMobileDevice = true;
                }
            }
        }
        catch (Exception)
        {
            IsMobileDevice = false;
        }

        if (IsMobileDevice)
        {
            if (!HttpContext.Current.Request.Url.ToString().Contains("localhost:"))
            {
                if (HttpContext.Current.Request.Url.ToString().Contains("uatweb.trepup.com"))
                {
                    HttpContext.Current.Response.Redirect(ReplaceInsensitive(ReplaceInsensitive(HttpContext.Current.Request.Url.ToString(), "http://uatweb.", "https://uatmobile."), "https://uatweb.", "https://uatmobile."), true);
                }
                else if (HttpContext.Current.Request.Url.ToString().Contains("staging.trepup.com"))
                {
                    HttpContext.Current.Response.Redirect(ReplaceInsensitive(ReplaceInsensitive(HttpContext.Current.Request.Url.ToString(), "http://staging.", "https://mstaging."), "https://staging.", "https://mstaging."), true);
                }
                else
                {
                    HttpContext.Current.Response.Redirect(ReplaceInsensitive(ReplaceInsensitive(HttpContext.Current.Request.Url.ToString(), "http://www.", "https://m."), "https://www.", "https://m."), true);
                }
            }

        }

    }

    static Regex MobileCheck = new Regex(@"(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled);
    static Regex MobileVersionCheck = new Regex(@"1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled);
    public static bool BrowserIsMobile()
    {
        if (HttpContext.Current.Request != null && HttpContext.Current.Request.ServerVariables["HTTP_USER_AGENT"] != null)
        {
            var u = HttpContext.Current.Request.ServerVariables["HTTP_USER_AGENT"].ToString();

            if (u.Length < 4)
                return false;

            if (MobileCheck.IsMatch(u) || MobileVersionCheck.IsMatch(u.Substring(0, 4)))
                return true;
        }

        return false;
    }

    #endregion MobileDeviceDetation



    #region GSTIN validation
    /// <summary>
    /// gstin validation
    /// </summary>
    /// <param name="inputtxt"></param>
    /// <returns></returns>
    public static bool GstValidation(string inputtxt)
    {
        bool Status = false;
        try
        {
            inputtxt = inputtxt.Trim();
            if (inputtxt == "" || inputtxt.Length < 15 || inputtxt.Length > 15)
            {
                Status = false;
            }
            else
            {
                int StateCode = Convert.ToInt16(inputtxt.Substring(0, 2));
                if (StateCode > 0 && StateCode <= 37)
                {
                    Regex pancardPattern = new Regex(@"^([a-zA-Z]){5}([0-9]){4}([a-zA-Z]){1}?$");
                    bool RegStatus = pancardPattern.IsMatch(inputtxt.Substring(2, 10));
                    if (RegStatus)
                    {
                        if (inputtxt[inputtxt.Length - 2].ToString().ToLower() == "z")
                        {
                            int EntityCount = Convert.ToInt16(inputtxt[inputtxt.Length - 3]);
                            if (EntityCount > 0)
                            {
                                Status = true;
                            }
                            else
                            {
                                Status = false;
                            }
                        }
                        else
                        {
                            Status = false;
                        }
                    }
                    else
                    {
                        Status = false;
                    }
                }
                else
                {
                    Status = false;
                }
            }

        }
        catch (Exception)
        {
            Status = false;
        }
        return Status;
    }

    /// <summary>
    /// pan number validation
    /// </summary>
    /// <param name="inputtxt"></param>
    /// <returns></returns>
    public static bool PanValidation(string inputtxt)
    {
        bool Status = false;
        try
        {
            inputtxt = inputtxt.Trim();
            if (inputtxt == "" || inputtxt.Length < 10 || inputtxt.Length > 10)
            {
                Status = false;
            }
            else
            {
                Regex panPattern = new Regex(@"^([a-zA-Z]){5}([0-9]){4}([a-zA-Z]){1}?$");
                if (panPattern.IsMatch(inputtxt))
                {
                    Status = true;
                }
                else
                {
                    Status = false;
                }
            }
        }
        catch (Exception)
        {
            Status = false;
        }
        return Status;
    }

    /// <summary>
    /// pan number validation
    /// </summary>
    /// <param name="inputtxt"></param>
    /// <returns></returns>
    public static bool TanValidation(string inputtxt)
    {
        bool Status = false;
        try
        {
            inputtxt = inputtxt.Trim();
            if (inputtxt == "" || inputtxt.Length < 10 || inputtxt.Length > 10)
            {
                Status = false;
            }
            else
            {
                Regex tanPattern = new Regex(@"^([a-zA-Z]){4}([0-9]){5}([a-zA-Z]){1}?$");
                if (tanPattern.IsMatch(inputtxt))
                {
                    Status = true;
                }
                else
                {
                    Status = false;
                }
            }
        }
        catch (Exception)
        {
            Status = false;
        }
        return Status;
    }
    #endregion

    #region valid link url
    public static string ValidateLinkUrl(string rawString)
    {
        string url = "";
        try
        {
            rawString = rawString.Replace("\n", "\r\n");
            string[] temp4;
            //char[] whitespace = new char[] { ' ', '\t', ' ', '\r'};
            //rawString = rawString.Replace("\n", "<br/>");
            char[] whitespace = new char[] { ' ', '\t', ' ', '\r' };
            string[] temp3 = rawString.Split(whitespace);
            ArrayList al = new ArrayList();
            string replacePattern1, replacePattern3, replacePattern6, replacePattern7, replacePattern8, replacePattern10;
            replacePattern1 = @"^([a-zA-Z0-9]|http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/|www\.|[a-zA-Z0-9])[a-zA-Z0-9]+([\-\.]{1}[a-zA-Z0-9]+)*\.[a-zA-Z]{2,5}(:[0-9]{1,5})?(\/.*)?$";

            //replacePattern2 = @"\A(?:[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?)\Z";

            replacePattern8 = @"\b^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)\b";//only http(s)

            replacePattern3 = @"(([a-zA-Z0-9\.])+@[a-zA-Z]+?(\.[" + TLDs + @"]{2,6})|^[@./#&+-:]\s+)";//@gmail.co.in
            replacePattern6 = @"(((http|https|ftp|news|file)+\:\/\/|(www\.)|[a-z0-9])[_.a-z0-9-]+\.[a-z0-9\/_:@=.+?,##%&~-]*[^.|\'|\# |!|\(|?|,| |>|<|;|\)]|^[@./#&+-:]\s+)";
            replacePattern10 = @"([\d\w-.]+?\.(a[cdefgilmnoqrstuwz]|b[abdefghijmnorstvwyz]|c[acdfghiklmnoruvxyz]|d[ejkmnoz]|e[ceghrst]|f[ijkmnor]|g[abdefghilmnpqrstuwy]|h[kmnrtu]|i[delmnoqrst]|j[emop]|k[eghimnprwyz]|l[abcikrstuvy]|m[acdghklmnopqrstuvwxyz]|n[acefgilopruz]|om|p[aefghklmnrstwy]|qa|r[eouw]|s[abcdeghijklmnortuvyz]|t[cdfghjkmnoprtvwz]|u[augkmsyz]|v[aceginu]|w[fs]|y[etu]|z[amw]|aero|arpa|biz|com|coop|edu|info|int|gov|mil|museum|name|net|org|pro)(\b|\W(?<!&|=)(?!\.\s|\.{3}).*?))(\s|$)";
            replacePattern7 = @"(((http|https|ftp|news|file)+\:\/\/|(www\.)[^a-z0-9])[_.a-z0-9-]+\.[a-z0-9\/_:@=.+?,##%&~-]*[^.|\'|\# |!|\(|?|,| |>|<|;|\)]([\S]*)|^[@./#&+-:])";
            Regex r = new Regex(replacePattern3, RegexOptions.IgnoreCase);
            Regex r1 = new Regex(replacePattern6, RegexOptions.IgnoreCase);
            Regex r2 = new Regex(replacePattern7, RegexOptions.IgnoreCase);

            foreach (string s in temp3)
            {
                if (Regex.IsMatch(s, replacePattern1, RegexOptions.IgnoreCase))
                {
                    if (!Regex.IsMatch(s, replacePattern8, RegexOptions.IgnoreCase))
                    {
                        if (Regex.IsMatch(s, replacePattern10, RegexOptions.IgnoreCase))
                        {
                            url = "http://" + s;
                        }
                    }
                    else if (Regex.IsMatch(s, replacePattern8, RegexOptions.IgnoreCase))
                    {
                        url = s;
                    }
                }
                else if (Regex.IsMatch(s, replacePattern6, RegexOptions.IgnoreCase))
                {
                    temp4 = Regex.Split(s, replacePattern6, RegexOptions.IgnoreCase);
                    if ((!s.ToLower().Contains("localhost:")))
                    {
                        if (temp4.Length == 5 || temp4.Length == 6)
                        {
                            if (Regex.IsMatch(temp4[1] + temp4[4], replacePattern1, RegexOptions.IgnoreCase))
                            {
                                if ((s.Contains("http://")) || (s.Contains("https://")))
                                {
                                    if (Regex.IsMatch(s, replacePattern10))
                                    {
                                        url = temp4[1] + temp4[4];
                                    }
                                }
                                else
                                {
                                    if (Regex.IsMatch(s, replacePattern10))
                                    {
                                        url = "http://" + temp4[1] + temp4[4];
                                    }
                                }
                            }
                        }
                        else if (temp4.Length < 5)
                        {
                            if (Regex.IsMatch(temp4[1], replacePattern1, RegexOptions.IgnoreCase))
                            {
                                if ((s.Contains("http://")) || (s.Contains("https://")))
                                {
                                    if (Regex.IsMatch(s, replacePattern10, RegexOptions.IgnoreCase))
                                    {
                                        url = temp4[1];
                                    }
                                }
                                else
                                {
                                    if (Regex.IsMatch(s, replacePattern10, RegexOptions.IgnoreCase))
                                    {
                                        url = "http://" + temp4[1];
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return url;
    }
    #endregion

    #region validate email

    public static bool ValidateEmail(string rawString)
    {
        bool email = false;
        try
        {
            string[] temp4;
            char[] whitespace = new char[] { ' ', '\t', ' ', '\r' };
            string[] temp3 = rawString.Split(whitespace);
            ArrayList al = new ArrayList();
            string replacePattern2, replacePattern3;
            //replacePattern2 = @"\A(?:[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?)\Z";
            replacePattern2 = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            replacePattern3 = @"(([a-zA-Z0-9\.])+@[a-zA-Z]+?(\.[" + TLDs + @"]{2,6})|^[@./#&+-:]\s+)";//@gmail.co.in

            foreach (string s in temp3)
            {
                if (Regex.IsMatch(s, replacePattern2, RegexOptions.IgnoreCase))
                {
                    if ((!s.Contains("www.")) && (s.Contains("@")))
                    {
                        //rawString = s.Replace(s, "<a class='changeLink' href='mailto:" + s + "' rel='nofollow'>" + s + "</a>");
                        //al.Add(rawString);
                        email = true;
                    }
                }
                else if (Regex.IsMatch(s, replacePattern3) && (!Regex.IsMatch(s, @"[0-9]\.")))
                {
                    if (Regex.IsMatch(s, replacePattern2, RegexOptions.IgnoreCase))
                    {
                        temp4 = Regex.Split(s, replacePattern3);
                        if (Regex.IsMatch(temp4[1] + temp4[4], replacePattern2, RegexOptions.IgnoreCase))
                        {
                            if ((!Regex.IsMatch(s, @"^[:\/:#]")))
                            {
                                //rawString = s.Replace(s, temp4[0] + "<a class='changeLink' href='mailto:" + temp4[1] + temp4[4] + "' rel='nofollow'>" + temp4[1] + temp4[4] + "</a>");
                                //al.Add(rawString);
                                email = true;
                            }
                        }
                    }
                    else if ((!Regex.IsMatch(s, @"^[:\/:#]")))
                    {
                        temp4 = Regex.Split(s, replacePattern3);
                        if (temp4.Length == 5 || temp4.Length == 6)
                        {
                            if (Regex.IsMatch(temp4[1] + temp4[4], replacePattern2, RegexOptions.IgnoreCase))
                            {
                                //rawString = s.Replace(s, temp4[0] + "<a class='changeLink' href='mailto:" + temp4[1] + temp4[4] + "' rel='nofollow'>" + temp4[1] + temp4[4] + "</a>");
                                //al.Add(rawString);
                                email = true;
                            }
                        }
                    }

                }
            }
        }
        catch (Exception ex)
        {
            email = false;
            throw ex;
        }
        return email;
    }

    /// <summary>
    /// Check blocked emails
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    public static bool CheckIsBlockedEmail(string email)
    {
        bool result = false;
        try
        {
            email = email.Trim().ToLower();
            if (email != "")
            {
                string[] arrEmailDomains = { "verifymybiz.com", "tradepassport.org", "burnermail.io", "10minutemail.com", "temp-mail.org", "qkjruledr.com", "emailondeck.com", "kingsready.com",
                     "guerrillamail.com", "sharklasers.com", "guerrillamail.info", "grr.la", "guerrillamail.biz", "guerrillamail.de", "guerrillamail.org",
                    "guerrillamailblock.com", "pokemail.net", "spam4.me", "yourinbox.mailcatch.com", "mailcatch.com", "my10minutemail.com", "trashmail.fr", "trashmail.se", "dropjar.com",
                    "itsjiff.com", "tmpbox.net", "moakt.cc", "disbox.net", "tmpmail.org", "tmpmail.net", "tmails.net", "disbox.org", "moakt.co", "moakt.ws", "tmail.ws",
                    "bareed.ws", "lsh.my.id", "main.truyenbb.com", "vusra.com", "ch.mintemail.com", "maildrop.cc", "nicoric.com", "nvhrw.com", "mailnesia.com", "mail-burst.com", "inboxkitten.com",
                    "email.com", "brite-mail.com", "altmails.com", "aiclbd.com", "mailthink.net", "sfletter.com", "datab.info", "trashspam.com", "plez.org", "1website.net", "airadding.com" };

                MailAddress address = new MailAddress(email);
                string host = address.Host.ToLower(); //host contains any of the fake email domains from the list
                foreach (string emailDomain in arrEmailDomains)
                {
                    if (host.Contains(emailDomain))
                    {
                        result = true;
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return result;
    }

    #endregion

    #region Check image file extension

    public static bool CheckPhotoFileExtension(string extension, short checkType = 0)
    {
        bool result = false;
        try
        {
            string photoValidatePattern = "^.*.(gif|jpg|jpeg|png)$";
            Regex RegExprValidPhoto = new Regex(photoValidatePattern, RegexOptions.IgnoreCase);
            result = RegExprValidPhoto.IsMatch(extension);
            RegExprValidPhoto = null;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return result;
    }

    #endregion

    #region check video file extension regex
    public static bool CheckVideoFileExtension(string extension)
    {
        bool result = false;
        try
        {
            string imgValidatePattern = "^.*.(3GP|AVI|WMV|MP4|WEBM|MOV|3gp|avi|wmv|mp4|webm|mov)$";
            Regex RegExprValidEmails = new Regex(imgValidatePattern, RegexOptions.IgnoreCase);
            result = RegExprValidEmails.IsMatch(extension);
            RegExprValidEmails = null;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return result;
    }
    #endregion


    public static void RedirectWithStatusCode(HttpResponse response, int statusCode, string location)
    {
        bool isServerTransfer = false;

        if (location.ToLower().Contains(".aspx"))
        {
            isServerTransfer = true;
        }

        if (!isServerTransfer)
        {
            response.Clear();
            response.Redirect(location, false);
            switch (statusCode)
            {
                case 200:
                    response.Status = "200 Ok";
                    response.StatusCode = (int)System.Net.HttpStatusCode.OK;
                    break;
                case 301:
                    response.Status = "301 Moved Permanently";
                    response.StatusCode = (int)System.Net.HttpStatusCode.MovedPermanently;
                    break;
                case 302:
                    response.Status = "302 Moved";
                    response.StatusCode = (int)System.Net.HttpStatusCode.Moved;
                    break;
                case 307:
                    response.Status = "307 Temporary Redirect";
                    response.StatusCode = (int)System.Net.HttpStatusCode.TemporaryRedirect;
                    break;
                case 500:
                    response.Status = "500 Internal Server Error";
                    response.StatusCode = (int)System.Net.HttpStatusCode.InternalServerError;
                    break;
                default:
                    response.Status = "404 Not Found";
                    response.StatusCode = (int)System.Net.HttpStatusCode.NotFound;
                    break;
            }

            response.Flush();
            response.End();
        }
        else
        {
            HttpContext.Current.Server.Transfer(location, false);
        }
    }

    public static string FormatNumber(double valueEnter)
    {
        string result = Convert.ToString(valueEnter);
        long tempResult = 0;
        if ((valueEnter / 1000000) >= 1)
        {
            tempResult = (long)Math.Round(valueEnter / 1000000);
            if (tempResult >= 100)
            {
                result = Convert.ToString(Math.Round(valueEnter / 1000000)) + "m";
            }
            else
            {
                double pointVal = (valueEnter / 1000000);
                string[] arrayResultSplit = Convert.ToString(pointVal).Split('.');
                if (arrayResultSplit[0].Length == 1)
                {
                    result = pointVal.ToString("N2") + "m";
                }
                else if (arrayResultSplit[0].Length == 2)
                {
                    result = pointVal.ToString("#,#0.0") + "m";
                }
                else
                {
                    result = pointVal + "m";
                }
            }
        }
        else if ((valueEnter / 1000) >= 1)
        {
            if (valueEnter <= 9999)
            {
                result = CommaSeparateNumber(Convert.ToString(valueEnter));
            }
            else
            {
                tempResult = (long)Math.Round(valueEnter / 1000);
                if (tempResult >= 100)
                {
                    result = Convert.ToString(Math.Round(valueEnter / 1000)) + "k";
                }
                else
                {
                    double pointVal = (valueEnter / 1000);
                    string[] arrayResultSplit = Convert.ToString(pointVal).Split('.');
                    if (arrayResultSplit[0].Length == 1)
                    {
                        result = pointVal.ToString("N2") + "k";
                    }
                    else if (arrayResultSplit[0].Length == 2)
                    {
                        result = pointVal.ToString("#,#0.0") + "k";
                    }
                    else
                    {
                        result = pointVal + "m";
                    }
                }
                if (result == "1,000k")
                {
                    result = "1m";
                }
            }
        }
        return result;
    }

    //public static string CommaSeparateNumber(string val, string curCode)
    //{
    //    string output = "";
    //    string[] arrayNumber = val.Split('.');
    //    switch (curCode.ToLower())
    //    {
    //        case "inr":
    //            output = Convert.ToInt64(arrayNumber[0]).ToString("#,#0", new System.Globalization.CultureInfo("en-IN"));
    //            break;
    //        default:
    //            output = Convert.ToInt64(arrayNumber[0]).ToString("#,##0", new System.Globalization.CultureInfo("en-US"));
    //            break;
    //    }
    //    if (arrayNumber.Length == 2)
    //    {
    //        output = output + "." + arrayNumber[1];
    //    }
    //    return output;
    //}

    public static string CommaSeparateNumber(string val, bool isCurrency = false, string curCode = "")
    {
        string output = "";
        //if (curCode == "")
        //{
        //    curCode = CookieManager.GetCookieValue<string>(ConfigurationManager.AppSettings["LoginCookieName"], "curCode", false).Trim();
        //}

        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
        switch (curCode.ToLower())
        {
            case "inr":
                nfi = new CultureInfo("en-IN", false).NumberFormat;
                int[] x = { 3, 2 };
                nfi.NumberGroupSizes = x;
                break;
        }
        output = Convert.ToDecimal(val).ToString("N", nfi);
        if (!isCurrency)
        {
            output = output.Split('.')[0];
        }
        else
        {
            if (output.IndexOf('.') == -1)
            {
                output = output + ".00";
            }
            else
            {
                string[] arrP = output.Split('.');
                if (arrP[1].Length > 2)
                {
                    output = arrP[0] + "." + arrP[1].Substring(0, 2);
                }
            }

            if (output.StartsWith("0.") || output.StartsWith("00."))
            {
                output = "1.00";
            }
        }
        nfi = null;
        return output;
    }

    ///// <summary>
    ///// set product price
    ///// </summary>
    ///// <param name="val"></param>
    ///// <param name="curCode"></param>
    ///// <returns></returns>
    //public static string SetProductPrice(string val, string curCode)
    //{
    //    string output = "", pattern = ""; Regex rgx;
    //    string[] arrayNumber = val.Split('.');
    //    switch (curCode.ToLower())
    //    {
    //        case "inr":
    //            // output = Convert.ToInt64(arrayNumber[0]).ToString("#,#0", new System.Globalization.CultureInfo("en-IN"));
    //            pattern = @"\B(?=(\d{2})+(?!\d))";
    //            rgx = new Regex(pattern);
    //            output = arrayNumber[0];
    //            string lastThree = output.Substring(output.Length - 3);
    //            string otherNumbers = output.Substring(0, output.Length - 3);
    //            if (otherNumbers != "")
    //            {
    //                lastThree = ',' + lastThree;
    //            }
    //            output = rgx.Replace(otherNumbers, ",") + lastThree;
    //            break;
    //        default:
    //            // output = Convert.ToInt64(arrayNumber[0]).ToString("#,##0", new System.Globalization.CultureInfo("en-US"));
    //            pattern = @"\B(?=(\d{3})+(?!\d))";
    //            rgx = new Regex(pattern);
    //            output = rgx.Replace(arrayNumber[0], ",");
    //            break;
    //    }
    //    if (arrayNumber.Length > 1)
    //    {
    //        switch (arrayNumber.Length)
    //        {
    //            case 1:
    //                output = output + "." + arrayNumber[1] + "0";
    //                break;
    //            case 2:
    //                output = output + "." + arrayNumber[1];
    //                break;
    //        }
    //    }
    //    else
    //    {
    //        output = output + ".00";
    //    }

    //    return output;
    //}

    #region user input encode/decode

    public static string BreakTagDecode(string text)
    {
        if (text == null)
        {
            return "";
        }
        else
        {
            text = text.Trim();
            if (text == "") { return text; }
            text = Regex.Replace(text, "&#92;&#110;", "<br/>", RegexOptions.IgnoreCase);
            text = Regex.Replace(text, "(?:\r\n|\r|\n)", "<br/>", RegexOptions.IgnoreCase);
            text = Regex.Replace(text, "&lt;br\\s*\\/&gt;", "<br/>", RegexOptions.IgnoreCase);
            text = Regex.Replace(text, "&lt;br&gt;", "<br/>", RegexOptions.IgnoreCase);
            return text;
        }
    }

    public static string HtmlEncode(string text)
    {
        if (text == null)
        {
            return "";
        }
        else
        {
            text = text.Trim();
            if (text == "") { return text; }
            //text = HttpUtility.HtmlEncode(text);
            text = text.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;").Replace("'", "&#x27;").Replace("/", "&#x2F;");
            return text;
        }
    }

    public static string HtmlDecode(string text)
    {
        if (text == null)
        {
            return "";
        }
        else
        {
            text = text.Trim();
            if (text == "") { return text; }
            //text = HttpUtility.HtmlDecode(text);
            text = text.Replace("&lt;", "<").Replace("&gt;", ">").Replace("&quot;", "\"").Replace("&#x27;", "'").Replace("&#x2F;", "/").Replace("&amp;", "&");
            return text;
        }
    }

    public static string TextDecode(string text)
    {
        if (text == null)
        {
            return "";
        }
        else
        {
            text = text.Trim();
            if (text == "") { return text; }
            text = text.Replace("&lt;", "<").Replace("&gt;", ">").Replace("&amp;", "&");
            return text;
        }
    }

    public static T JSONTextDecode<T>(T Obj)
    {
        T result = default(T);

        JavaScriptSerializer ser = new JavaScriptSerializer();
        var nodes = ser.Deserialize<dynamic>(ser.Serialize(Obj));
        result = ser.Deserialize<T>(ser.Serialize(LoopJson(nodes)));

        return result;
    }

    public static dynamic LoopJson(dynamic nodes)
    {
        JavaScriptSerializer ser = new JavaScriptSerializer();
        //dynamic nodeLoop = JsonConvert.DeserializeObject<dynamic>(JsonConvert.SerializeObject(nodes));

        dynamic nodeLoop = ser.Deserialize<dynamic>(ser.Serialize(nodes));

        foreach (var item in nodes)
        {
            string theKey = item.Key;
            var thisNode = item.Value;
            if (thisNode != null)
            {
                if (thisNode.GetType() == typeof(System.Collections.Generic.Dictionary<string, object>))
                {
                    nodeLoop[theKey] = LoopJson(thisNode);
                }
                else if (thisNode.GetType() == typeof(string))
                {
                    nodeLoop[theKey] = TextDecode(thisNode);
                }
                else
                {
                    nodeLoop[theKey] = thisNode;
                }
            }
            else
            {
                nodeLoop[theKey] = item.Value;
            }

        }

        ser = null;
        return nodeLoop;
    }

    #endregion

    #region Json Html decode
    //public static T SanitizeParam<T>(object json)
    //{
    //    //if (typeof obj === "object") {
    //    //    for (var key in obj) {
    //    //        if (typeof obj[key] === "object") {
    //    //            obj[key] = $.fn.SanitizeParam(obj[key]);
    //    //        }
    //    //        else {
    //    //            if (obj.hasOwnProperty(key)) {
    //    //                obj[key] = $.fn.TextEncode($.trim(obj[key]));
    //    //            }
    //    //        }
    //    //    }
    //    //} else {
    //    //    obj = $.fn.TextEncode($.trim(obj));
    //    //}
    //    T obj = default(T);
    //    obj = (T)json;
    //    if (json != null)
    //    {
    //        foreach(var key in obj)
    //        {
    //            if (typeof(T).Name == object)
    //            {
    //            }
    //            else
    //            {
    //                obj[key] = Common.HtmlDecode(Convert.ToString(obj[key]).Trim());
    //            }
    //        }
    //    }
    //    return obj;
    //}
    #endregion


    public static void DoCompression(HttpContext context)
    {
        HttpRequest request = context.Request;
        string acceptEncoding = request.Headers["Accept-Encoding"];
        HttpResponse response = context.Response;
        if (!string.IsNullOrEmpty(acceptEncoding))
        {
            acceptEncoding = acceptEncoding.ToUpperInvariant();
            if (acceptEncoding.Contains("GZIP"))
            {
                response.Filter = new GZipStream(context.Response.Filter,
                CompressionMode.Compress);
                response.AppendHeader("Content-encoding", "gzip");
            }
            else if (acceptEncoding.Contains("DEFLATE"))
            {
                response.Filter = new DeflateStream(context.Response.Filter,
                CompressionMode.Compress);
                response.AppendHeader("Content-encoding", "deflate");
            }
        }
        response.Cache.VaryByHeaders["Accept-Encoding"] = true;
    }

    public static List<Dictionary<string, object>> DataTableToList(DataTable table)
    {
        List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();

        foreach (DataRow row in table.Rows)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();

            foreach (DataColumn col in table.Columns)
            {
                dict[col.ColumnName] = row[col];
            }
            list.Add(dict);
        }

        return list;
    }

    public static DataTable ListToDataTable<T>(List<T> items, bool isDBNull = false)
    {
        DataTable dataTable = new DataTable(typeof(T).Name);
        //Get all the properties by using reflection   
        PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (PropertyInfo prop in Props)
        {
            //Setting column names as Property names  
            dataTable.Columns.Add(prop.Name);
        }
        foreach (T item in items)
        {
            var values = new object[Props.Length];
            for (int i = 0; i < Props.Length; i++)
            {
                values[i] = Props[i].GetValue(item, null);
                //if (isDBNull && values[i] == null || (values[i].GetType() ==typeof(String) && string.IsNullOrEmpty(Convert.ToString(values[i]))))
                if (isDBNull && (values[i] == null || Convert.ToString(values[i]) == "" || Convert.ToString(values[i]) == "0"))
                {
                    values[i] = DBNull.Value;
                }

            }
            dataTable.Rows.Add(values);
        }

        return dataTable;
    }


    public static DataTable ListToDataTableWithDBType<T>(List<T> items)
    {
        DataTable dataTable = new DataTable(typeof(T).Name);
        //Get all the properties by using reflection   
        PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (PropertyInfo prop in Props)
        {
            //Defining type of data column gives proper data table 
            var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
            //Setting column names as Property names
            dataTable.Columns.Add(prop.Name, type);
        }
        foreach (T item in items)
        {
            var values = new object[Props.Length];
            for (int i = 0; i < Props.Length; i++)
            {
                values[i] = Props[i].GetValue(item, null);


            }
            dataTable.Rows.Add(values);
        }

        return dataTable;
    }


    /// <summary>
    /// Get BitMap Image From URL
    /// </summary>
    /// <param name="URL"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <returns></returns>
    public static Bitmap GetBitMapFromURL(string URL, int width = 300, int height = 300)
    {
        Bitmap objBitmap = new Bitmap(width, height);
        Bitmap bmpLogo = null;

        WebClient objWebClient = new WebClient();
        try
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            objWebClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.84 Safari/537.36");
            objWebClient.Headers.Add("Timeout", "60000");
            bmpLogo = (Bitmap)Image.FromStream(objWebClient.OpenRead(URL));

            int left = (objBitmap.Width / 2) - (bmpLogo.Width / 2);
            int top = (objBitmap.Height / 2) - (bmpLogo.Height / 2);

            Graphics objGraphic = Graphics.FromImage(objBitmap);
            objGraphic.DrawImage(bmpLogo, new Point(left, top));

            objGraphic = null;
        }
        catch (Exception ex)
        {
            objBitmap = null;
            throw ex;
        }
        finally
        {
            objWebClient = null;
            bmpLogo = null;
        }
        return objBitmap;
    }

    /// <summary>
    /// get currency symbol by currency id
    /// </summary>
    /// <param name="currencyID"></param>
    /// <returns></returns>
    public static string GetCurrencySymbolByCurrencyID(int currencyID)
    {
        try
        {
            string symbol = "";
            if (currencyID != 0)
            {
                string jsonCurrecny = "{\"lstCurrencyDetails\":[{\"currencyID\":1,\"currencySymbol\":\"؋\"},{\"currencyID\":2,\"currencySymbol\":\"Lek\"},{\"currencyID\":3,\"currencySymbol\":\"‎دج\"},{\"currencyID\":4,\"currencySymbol\":\"Kz\"},{\"currencyID\":5,\"currencySymbol\":\"$\"},{\"currencyID\":6,\"currencySymbol\":\"֏\"},{\"currencyID\":7,\"currencySymbol\":\"ƒ\"},{\"currencyID\":8,\"currencySymbol\":\"$\"},{\"currencyID\":9,\"currencySymbol\":\"₼\"},{\"currencyID\":10,\"currencySymbol\":\"$\"},{\"currencyID\":11,\"currencySymbol\":\"BD\"},{\"currencyID\":12,\"currencySymbol\":\"Tk\"},{\"currencyID\":13,\"currencySymbol\":\"Bds$\"},{\"currencyID\":14,\"currencySymbol\":\"M\"},{\"currencyID\":15,\"currencySymbol\":\"Br\"},{\"currencyID\":16,\"currencySymbol\":\"BZ$\"},{\"currencyID\":17,\"currencySymbol\":\"$\"},{\"currencyID\":18,\"currencySymbol\":\"Nu.\"},{\"currencyID\":19,\"currencySymbol\":\"B͈̎\"},{\"currencyID\":20,\"currencySymbol\":\"Bs.\"},{\"currencyID\":21,\"currencySymbol\":\"KM\"},{\"currencyID\":22,\"currencySymbol\":\"P\"},{\"currencyID\":23,\"currencySymbol\":\"R$\"},{\"currencyID\":24,\"currencySymbol\":\"£\"},{\"currencyID\":25,\"currencySymbol\":\"B$\"},{\"currencyID\":26,\"currencySymbol\":\"лв.\"},{\"currencyID\":27,\"currencySymbol\":\"K\"},{\"currencyID\":28,\"currencySymbol\":\"Fbu\"},{\"currencyID\":29,\"currencySymbol\":\"៛\"},{\"currencyID\":30,\"currencySymbol\":\"C$\"},{\"currencyID\":31,\"currencySymbol\":\"$\"},{\"currencyID\":32,\"currencySymbol\":\"$\"},{\"currencyID\":33,\"currencySymbol\":\"FCFA\"},{\"currencyID\":34,\"currencySymbol\":\"CFP\"},{\"currencyID\":35,\"currencySymbol\":\"CLP$\"},{\"currencyID\":36,\"currencySymbol\":\"¥\"},{\"currencyID\":37,\"currencySymbol\":\"COL$\"},{\"currencyID\":38,\"currencySymbol\":\"CF\"},{\"currencyID\":39,\"currencySymbol\":\"FC\"},{\"currencyID\":40,\"currencySymbol\":\"₡\"},{\"currencyID\":41,\"currencySymbol\":\"kn\"},{\"currencyID\":42,\"currencySymbol\":\"CUC$\"},{\"currencyID\":43,\"currencySymbol\":\"₱\"},{\"currencyID\":44,\"currencySymbol\":\"Kč\"},{\"currencyID\":45,\"currencySymbol\":\"kr\"},{\"currencyID\":46,\"currencySymbol\":\"Fdj\"},{\"currencyID\":47,\"currencySymbol\":\"RD$\"},{\"currencyID\":48,\"currencySymbol\":\"EC$\"},{\"currencyID\":49,\"currencySymbol\":\"E£\"},{\"currencyID\":50,\"currencySymbol\":\"د.إ\"},{\"currencyID\":51,\"currencySymbol\":\"ናቕፋ\"},{\"currencyID\":52,\"currencySymbol\":\"ብር\"},{\"currencyID\":53,\"currencySymbol\":\"€\"},{\"currencyID\":54,\"currencySymbol\":\"FK£\"},{\"currencyID\":55,\"currencySymbol\":\"FJ$\"},{\"currencyID\":56,\"currencySymbol\":\"D\"},{\"currencyID\":57,\"currencySymbol\":\"₾\"},{\"currencyID\":58,\"currencySymbol\":\"GH₵\"},{\"currencyID\":59,\"currencySymbol\":\"£\"},{\"currencyID\":60,\"currencySymbol\":\"Q\"},{\"currencyID\":61,\"currencySymbol\":\"£\"},{\"currencyID\":62,\"currencySymbol\":\"FG\"},{\"currencyID\":63,\"currencySymbol\":\"G$\"},{\"currencyID\":64,\"currencySymbol\":\"G\"},{\"currencyID\":65,\"currencySymbol\":\"L\"},{\"currencyID\":66,\"currencySymbol\":\"HK$\"},{\"currencyID\":67,\"currencySymbol\":\"Ft\"},{\"currencyID\":68,\"currencySymbol\":\"kr\"},{\"currencyID\":69,\"currencySymbol\":\"₹\"},{\"currencyID\":70,\"currencySymbol\":\"Rp\"},{\"currencyID\":71,\"currencySymbol\":\"﷼\"},{\"currencyID\":72,\"currencySymbol\":\"ع.د\"},{\"currencyID\":73,\"currencySymbol\":\"₪\"},{\"currencyID\":74,\"currencySymbol\":\"J$\"},{\"currencyID\":75,\"currencySymbol\":\"¥\"},{\"currencyID\":76,\"currencySymbol\":\"£\"},{\"currencyID\":77,\"currencySymbol\":\"JD\"},{\"currencyID\":78,\"currencySymbol\":\"₸\"},{\"currencyID\":79,\"currencySymbol\":\"KSh\"},{\"currencyID\":80,\"currencySymbol\":\"ك\"},{\"currencyID\":81,\"currencySymbol\":\"лв\"},{\"currencyID\":82,\"currencySymbol\":\"₭\"},{\"currencyID\":83,\"currencySymbol\":\"ل.ل.\"},{\"currencyID\":84,\"currencySymbol\":\"L$\"},{\"currencyID\":85,\"currencySymbol\":\"ل.د\"},{\"currencyID\":86,\"currencySymbol\":\"MOP$\"},{\"currencyID\":87,\"currencySymbol\":\"ден\"},{\"currencyID\":88,\"currencySymbol\":\"Ar\"},{\"currencyID\":89,\"currencySymbol\":\"MK\"},{\"currencyID\":90,\"currencySymbol\":\"RM\"},{\"currencyID\":91,\"currencySymbol\":\"Rf\"},{\"currencyID\":92,\"currencySymbol\":\"£\"},{\"currencyID\":93,\"currencySymbol\":\"UM\"},{\"currencyID\":94,\"currencySymbol\":\"₨\"},{\"currencyID\":95,\"currencySymbol\":\"Mex$\"},{\"currencyID\":96,\"currencySymbol\":\"Lei\"},{\"currencyID\":97,\"currencySymbol\":\"₮\"},{\"currencyID\":98,\"currencySymbol\":\"MAD\"},{\"currencyID\":99,\"currencySymbol\":\"MT\"},{\"currencyID\":100,\"currencySymbol\":\"N$\"},{\"currencyID\":101,\"currencySymbol\":\"रू\"},{\"currencyID\":102,\"currencySymbol\":\"NT$\"},{\"currencyID\":103,\"currencySymbol\":\"NZ$\"},{\"currencyID\":104,\"currencySymbol\":\"C$\"},{\"currencyID\":105,\"currencySymbol\":\"₦\"},{\"currencyID\":106,\"currencySymbol\":\"₩\"},{\"currencyID\":107,\"currencySymbol\":\"kr\"},{\"currencyID\":108,\"currencySymbol\":\"ر.ع.\"},{\"currencyID\":109,\"currencySymbol\":\"₨\"},{\"currencyID\":110,\"currencySymbol\":\"B/.\"},{\"currencyID\":111,\"currencySymbol\":\"K\"},{\"currencyID\":112,\"currencySymbol\":\"Gs\"},{\"currencyID\":113,\"currencySymbol\":\"S/.\"},{\"currencyID\":114,\"currencySymbol\":\"₱\"},{\"currencyID\":115,\"currencySymbol\":\"zł\"},{\"currencyID\":116,\"currencySymbol\":\"﷼\"},{\"currencyID\":117,\"currencySymbol\":\"L\"},{\"currencyID\":118,\"currencySymbol\":\"₽\"},{\"currencyID\":119,\"currencySymbol\":\"FRw\"},{\"currencyID\":120,\"currencySymbol\":\"£\"},{\"currencyID\":121,\"currencySymbol\":\"WS$\"},{\"currencyID\":122,\"currencySymbol\":\"Db\"},{\"currencyID\":123,\"currencySymbol\":\"﷼\"},{\"currencyID\":124,\"currencySymbol\":\"Дин.\"},{\"currencyID\":125,\"currencySymbol\":\"SR\"},{\"currencyID\":126,\"currencySymbol\":\"Le\"},{\"currencyID\":127,\"currencySymbol\":\"S$\"},{\"currencyID\":128,\"currencySymbol\":\"SI$\"},{\"currencyID\":129,\"currencySymbol\":\"S\"},{\"currencyID\":130,\"currencySymbol\":\"R\"},{\"currencyID\":131,\"currencySymbol\":\"₩\"},{\"currencyID\":132,\"currencySymbol\":\"£\"},{\"currencyID\":133,\"currencySymbol\":\"රු\"},{\"currencyID\":134,\"currencySymbol\":\"ج.س\"},{\"currencyID\":135,\"currencySymbol\":\"$\"},{\"currencyID\":136,\"currencySymbol\":\"E\"},{\"currencyID\":137,\"currencySymbol\":\"kr\"},{\"currencyID\":138,\"currencySymbol\":\"CHF\"},{\"currencyID\":139,\"currencySymbol\":\"£\"},{\"currencyID\":140,\"currencySymbol\":\"SM\"},{\"currencyID\":141,\"currencySymbol\":\"TSh\"},{\"currencyID\":142,\"currencySymbol\":\"฿\"},{\"currencyID\":143,\"currencySymbol\":\"T$\"},{\"currencyID\":144,\"currencySymbol\":\"TT$\"},{\"currencyID\":145,\"currencySymbol\":\"د.ت\"},{\"currencyID\":146,\"currencySymbol\":\"₺\"},{\"currencyID\":147,\"currencySymbol\":\"T\"},{\"currencyID\":148,\"currencySymbol\":\"TV$\"},{\"currencyID\":149,\"currencySymbol\":\"Ush\"},{\"currencyID\":150,\"currencySymbol\":\"₴\"},{\"currencyID\":151,\"currencySymbol\":\"US$\"},{\"currencyID\":152,\"currencySymbol\":\"$U\"},{\"currencyID\":153,\"currencySymbol\":\"лв\"},{\"currencyID\":154,\"currencySymbol\":\"VT\"},{\"currencyID\":155,\"currencySymbol\":\"Bs.\"},{\"currencyID\":156,\"currencySymbol\":\"₫\"},{\"currencyID\":157,\"currencySymbol\":\"CFA\"},{\"currencyID\":158,\"currencySymbol\":\"﷼\"},{\"currencyID\":159,\"currencySymbol\":\"ZK\"},{\"currencyID\":160,\"currencySymbol\":\"Z$\"}]}";
                CurrencySymbolDetails objCurrencySymbolDetails = JsonConvert.DeserializeObject<CurrencySymbolDetails>(jsonCurrecny);
                CurrencyDetails lstSearchCurrencyValue = objCurrencySymbolDetails.lstCurrencyDetails.Find(item => item.currencyID == currencyID);
                if (lstSearchCurrencyValue != null && lstSearchCurrencyValue.currencySymbol != null && lstSearchCurrencyValue.currencySymbol != "")
                {
                    symbol = lstSearchCurrencyValue.currencySymbol;
                }
                lstSearchCurrencyValue = null;
                objCurrencySymbolDetails = null;
            }
            return symbol;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public class CurrencySymbolDetails
    {
        public List<CurrencyDetails> lstCurrencyDetails { get; set; }
    }

    public class CurrencyDetails
    {
        public int currencyID { get; set; }
        public string currencySymbol { get; set; }
    }

    /// <summary>
    /// common business and user profile links class
    /// </summary>
    public class EntityProfileLinks
    {
        public string linkTitle { get; set; }
        public string linkURL { get; set; }
        public string linkKey { get; set; }
        public string socialIcon { get; set; }
        public string domainName { get; set; }
    }

    #region Navigation Band HTML

    //public static HtmlGenericControl GetNavigationBandHTML(NavigationBandDetails[] objMenuDetails, bool isTopLine = false)
    //{
    //    HtmlGenericControl ctrlNav = new HtmlGenericControl("nav");

    //    string headerHTML = "<ul class=\"RobotoRegular\">", isActiveClass = "", isActiveSub = "", navClass = "headerNavMenuInner mhTop";
    //    foreach (NavigationBandDetails menuDetails in objMenuDetails)
    //    {

    //        if (menuDetails.IsActive)
    //        {
    //            isActiveClass = " class=\"active" + (menuDetails.SubMenu != null ? " subMenuHolder" : "") + " \" ";
    //            isActiveSub = "active";
    //        }
    //        else
    //        {
    //            isActiveClass = (menuDetails.SubMenu != null ? " calss=\"subMenuHolder\" " : "");
    //            isActiveSub = "";
    //        }

    //        headerHTML += "<li id=\"li" + menuDetails.Name.Replace(" ", "") + "\" " + isActiveClass + " >" +
    //                        (!menuDetails.IsActive && menuDetails.SubMenu == null && menuDetails.Url != "" ? "<a href=\"" + menuDetails.Url + "\"" : "<span ") + " title =\"" + menuDetails.Title + "\" class=\"RobotoRegular text\">" +
    //                          "<span class=\"inline-flex\">" + menuDetails.Name + "</span>" +
    //                           (menuDetails.SubMenu != null ? "<span class=\"inline-flex subMenuIcon " + isActiveSub + " \"><i class=\"tu_dropdown-big tufont_10 tufont_lightblack\"></i></span>" : "") +
    //                          (!menuDetails.IsActive && menuDetails.SubMenu == null && menuDetails.Url != "" ? "</a>" : "</span>") +
    //                          (menuDetails.IsActive ? "<span class=\"bottomBorder\"></span>" : "") +
    //                          (menuDetails.SubMenu != null ? GetNavigationBandSubMenu(menuDetails.SubMenu) : "") +
    //                         "</li>";

    //    }

    //    headerHTML += "</ul>";


    //    if (isTopLine) { navClass += " border-t-e5"; }

    //    ctrlNav.Attributes.Add("class", navClass);

    //    ctrlNav.InnerHtml = headerHTML;

    //    //ctrlNav.Attributes.Add("align", "center");

    //    objMenuDetails = null;

    //    return ctrlNav;
    //}

    //public static string GetNavigationBandSubMenu(SubNavigationBandDetails[] objMenuDetails)
    //{
    //    string headerHTML = "<div class=\"headerSubMenu\"><ul class=\"RobotoRegular\">", isActiveClass = "";
    //    foreach (SubNavigationBandDetails menuDetails in objMenuDetails)
    //    {

    //        if (menuDetails.IsActive)
    //        {
    //            isActiveClass = " class=\"active\" ";
    //        }
    //        else
    //        {
    //            isActiveClass = "";
    //        }

    //        //headerHTML += "<li id=\"li" + menuDetails.Name.Replace(" ", "") + "\" " + isActiveClass + ">" +
    //        //              (!menuDetails.IsActive ? "<a href=\"" + menuDetails.Url + "\"" : "<span ") + " title =\"" + menuDetails.Title + "\">" +
    //        //                "<span class=\"inline-flex\">" + menuDetails.Name + "</span>" +
    //        //                //(menuDetails.IsActive ? "<span class=\"bottomBorder\"></span>" : "") +
    //        //                (!menuDetails.IsActive ? "</a>" : "</span>") +
    //        //               "</li>";

    //        headerHTML += "<li id=\"li" + menuDetails.Name.Replace(" ", "") + "\" " + isActiveClass + ">" +
    //                         "<a href=\"" + menuDetails.Url + "\"" + " title =\"" + menuDetails.Title + "\">" +
    //                           "<span class=\"inline-flex\">" + menuDetails.Name + "</span>" +
    //                         "</a>" +
    //                      "</li>";

    //    }

    //    headerHTML += "</ul></div>";

    //    return headerHTML;
    //}

    //public static HtmlGenericControl GetStepsNavigationBandHTML(StepsNavigationBandDetails[] objMenuDetails)
    //{
    //    HtmlGenericControl ctrlNav = new HtmlGenericControl("div");

    //    string headerHTML = "", isActiveClass = "", isCursorClass = ""; int index = 0;
    //    foreach (StepsNavigationBandDetails menuDetails in objMenuDetails)
    //    {
    //        if (menuDetails.IsActive)
    //        {
    //            isActiveClass = " active-black";
    //            isCursorClass = "";
    //        }
    //        else
    //        {
    //            isActiveClass = "";
    //        }

    //        if (menuDetails.IsCursor)
    //        {
    //            isCursorClass = " cursor";
    //        }
    //        else
    //        {
    //            isCursorClass = "";
    //        }
    //        headerHTML += (!menuDetails.IsActive && menuDetails.Url != "" ? "<a href=\"" + menuDetails.Url + "\"" : "<span id=\"spn" + menuDetails.Name + "Navigation\"") +
    //            " class=\"fl textHolder RobotoRegular ft-13 cl-gray " + menuDetails.StepCnt + isActiveClass + isCursorClass + "\">" + (index + 1) + ". " + menuDetails.Name +
    //             (!menuDetails.IsActive && menuDetails.Url != "" ? "</a>" : "</span>");
    //        if (index < objMenuDetails.Length - 1)
    //        {
    //            headerHTML += "<span class=\"fl RobotoRegular arrowHolder mar-l-20 mar-r-20\"><i class=\"tu_arrow-right tufont_12\"></i></span>";
    //        }

    //        index++;
    //    }

    //    ctrlNav.Attributes.Add("id", "divHeaderStepNav");
    //    ctrlNav.Attributes.Add("class", "header-step-nav-holder overflow-h");

    //    ctrlNav.InnerHtml = headerHTML;

    //    //ctrlNav.Attributes.Add("align", "center");

    //    objMenuDetails = null;

    //    return ctrlNav;
    //}

    //public static HtmlGenericControl GetBreadCrumbHTML(NavigationBandDetails[] objMenuDetails, bool isTopLine = false)
    //{
    //    HtmlGenericControl ctrlDiv = new HtmlGenericControl("div");

    //    string headerHTML = "", divClass = "top-breadcrumb", margin = "";
    //    var i = 0;
    //    foreach (NavigationBandDetails menuDetails in objMenuDetails)
    //    {
    //        if (menuDetails.IsActive) //to allow navigation IsActive = true
    //        {
    //            if (i != 0)
    //            {
    //                margin = " mar-l-5";
    //            }
    //            headerHTML += "<a class=\"top-breadcrumb-inactive RobotoRegular" + margin + "\" href=\"" + menuDetails.Url + "\" title=\"" + menuDetails.Title + "\">" + menuDetails.Name + " <i class=\"tu_arrow-right tufont_arrow tufont_8\"></i></a>";
    //        }
    //        else
    //        {
    //            headerHTML += "<span class=\"top-breadcrumb-active RobotoRegular mar-l-5\">" + menuDetails.Name + "</span>";
    //        }
    //        i += 1;
    //    }


    //    ctrlDiv.Attributes.Add("class", divClass);

    //    ctrlDiv.InnerHtml = headerHTML;

    //    objMenuDetails = null;

    //    return ctrlDiv;
    //}

    #endregion


    public static bool ValidateStringForURL(string text)
    {
        //string pattern = @"(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+";
        string pattern = @"\b(?:https?://|www\.)\S+\b";
        return Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
    }

    public static bool IsMobileOrBrowser()
    {
        //GETS THE CURRENT USER CONTEXT
        HttpContext context = HttpContext.Current;

        //FIRST TRY BUILT IN ASP.NT CHECK
        if (context.Request.Browser.IsMobileDevice)
        {
            return true;
        }
        //THEN TRY CHECKING FOR THE HTTP_X_WAP_PROFILE HEADER
        if (context.Request.ServerVariables["HTTP_X_WAP_PROFILE"] != null)
        {
            return true;
        }
        //THEN TRY CHECKING THAT HTTP_ACCEPT EXISTS AND CONTAINS WAP
        if (context.Request.ServerVariables["HTTP_ACCEPT"] != null &&
            context.Request.ServerVariables["HTTP_ACCEPT"].ToLower().Contains("wap"))
        {
            return true;
        }
        //AND FINALLY CHECK THE HTTP_USER_AGENT 
        //HEADER VARIABLE FOR ANY ONE OF THE FOLLOWING
        if (context.Request.ServerVariables["HTTP_USER_AGENT"] != null)
        {
            //Create a list of all mobile types
            string[] mobiles =
                new[]
                {
                    "midp", "j2me", "avant", "docomo",
                    "novarra", "palmos", "palmsource",
                    "240x320", "opwv", "chtml",
                    "pda", "windows ce", "mmp/",
                    "blackberry", "mib/", "symbian",
                    "wireless", "nokia", "hand", "mobi",
                    "phone", "cdm", "up.b", "audio",
                    "SIE-", "SEC-", "samsung", "HTC",
                    "mot-", "mitsu", "sagem", "sony"
                    , "alcatel", "lg", "eric", "vx",
                    "NEC", "philips", "mmm", "xx",
                    "panasonic", "sharp", "wap", "sch",
                    "rover", "pocket", "benq", "java",
                    "pt", "pg", "vox", "amoi",
                    "bird", "compal", "kg", "voda",
                    "sany", "kdd", "dbt", "sendo",
                    "sgh", "gradi", "jb", "dddi",
                    "moto", "iphone","ipad","ipod","windowsphone" ,"mobile" ,"tablet"
                };

            //Loop through each item in the list created above 
            //and check if the header contains that text
            foreach (string s in mobiles)
            {
                if (context.Request.ServerVariables["HTTP_USER_AGENT"].
                                                    ToLower().Contains(s.ToLower()))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static PasswordStrength GetPasswordStrength(string password, string firstName, string lastName, string email)
    {
        PasswordStrength objPwdStrength = new PasswordStrength();
        objPwdStrength.result = true;
        objPwdStrength.message = "success";

        try
        {
            Regex regexNumber = new Regex(@"[0-9]");
            Regex regexSpecailChar = new Regex(@"[\*\""\[\]\-\\\/|:<>{}~!?`#%^,+_();@&$=]");

            password = password.Trim().ToLower();
            if (!string.IsNullOrEmpty(password))
            {
                firstName = firstName.Trim().ToLower();
                lastName = lastName.Trim().ToLower();
                email = email.Trim().ToLower();

                if (password.Contains(firstName) || password.Contains(lastName) || password.Contains(email))
                {
                    objPwdStrength.result = false;
                    objPwdStrength.message = "Cannot contain your name or email address";
                }
                else if (password.Length < 8 || password.Length > 20)
                {
                    objPwdStrength.result = false;
                    objPwdStrength.message = "At least 8 characters";
                }
                else if (!regexNumber.IsMatch(password) && !regexSpecailChar.IsMatch(password))
                {
                    objPwdStrength.result = false;
                    objPwdStrength.message = "Must contain a number or symbol";
                }
            }
        }
        catch (Exception)
        {
            objPwdStrength.result = false;
            objPwdStrength.message = "Password strength: weak";
        }

        return objPwdStrength;
    }

    public class PasswordStrength
    {
        public bool result { get; set; }
        public string message { get; set; }
    }

    public static string SetSearchHashTags(string desc, string whenUpdated, string postType, string isLoggedIn)
    {
        string websitePath = Convert.ToString(ConfigurationManager.AppSettings["WebsitePath"]);
        string hashTagPattern = @"(^|\s)(#[a-zA-Z0-9]+)";
        Match result = Regex.Match(desc, hashTagPattern);
        if (result.Success)
        {
            if (isLoggedIn.Trim().Equals("0"))
            {
                desc = Regex.Replace(desc, @"\/>", "/> ");
                desc = Regex.Replace(desc, hashTagPattern, "$1<span tu-fn class=\"hashtag\" title=\"Search for $2\" tu-fn-click=\"ShowNotificationSignupLogin()\">$2</span>");
            }
            else
            {
                if (!string.IsNullOrEmpty(postType))
                {
                    string timeDiff = Common.ShowTime(Convert.ToDateTime(whenUpdated));
                    if (timeDiff != null && timeDiff != "")
                    {
                        if (timeDiff.ToLower().IndexOf("seconds") != -1) { return desc; }

                        if (timeDiff.ToLower().IndexOf("minutes") != -1 || timeDiff.ToLower().IndexOf("minute") != -1)
                        {
                            int minCount = Convert.ToInt32(timeDiff.Split(' ')[0]);
                            if (minCount >= 10)
                            {
                                desc = Regex.Replace(desc, @"\/>", "/> ");
                                desc = Regex.Replace(desc, hashTagPattern, "$1<a class=\"hashtag\" title=\"Search for $2\"  target=\"_blank\" href=\"" + websitePath + "trepboard/" + postType + "/?q=$2\">$2</a>");
                            }
                        }
                        else
                        {
                            desc = Regex.Replace(desc, @"\/>", "/> ");
                            desc = Regex.Replace(desc, hashTagPattern, (match) =>
                            {
                                return "<a class=\"hashtag\" title=\"Search for " + match.Value.Trim() + "\"  target=\"_blank\" href=\"" + websitePath + "trepboard/" + postType + "/?q=" + HttpUtility.UrlEncode(match.Value.Trim()) + "\">" + match.Value + "</a>";
                            });
                        }
                    }
                    else
                    {
                        desc = Regex.Replace(desc, @"\/>", "/> ");
                        desc = Regex.Replace(desc, hashTagPattern, "$1<a class=\"hashtag\" title=\"Search for $2\"  target=\"_blank\" href=\"" + websitePath + "trepboard/" + postType + "/?q=$2\">$2</a>");
                    }
                }
            }
        }
        return desc;
    }

    public static string GetQueryStringURL(dynamic resultData)
    {
        var resultLst = new List<string>();
        foreach (var exObjProp in resultData as IDictionary<string, object> ?? new Dictionary<string, object>())
        {
            resultLst.Add(Convert.ToString(exObjProp.Key) + "=" + HttpUtility.UrlEncode(Convert.ToString(exObjProp.Value)));
        }
        return string.Join("&", resultLst);
    }

    public class UserTimeZoneResponse
    {
        public List<TimeZoneDetails> TimeZone { get; set; }
    }
    public class TimeZoneDetails
    {
        public string ZoneName { get; set; }
        public string TimeZoneName { get; set; }
    }

    //#endregion

    public static string XSSProtect(string input)
    {
        string returnVal = input ?? "";

        returnVal = Regex.Replace(returnVal, @"\<script(.*?)\>(.*?)\<\/script(.*?)\>", "", RegexOptions.Singleline | RegexOptions.IgnoreCase);
        //returnVal = Regex.Replace(returnVal, @"\<style(.*?)\>(.*?)\<\/style(.*?)\>", "", RegexOptions.Singleline | RegexOptions.IgnoreCase);

        while (Regex.IsMatch(returnVal, @"(<[\s\S]*?) on.*?\=(['""])[\s\S]*?\2([\s\S]*?>)", RegexOptions.Compiled | RegexOptions.IgnoreCase))
        {
            returnVal = Regex.Replace(returnVal, @"(<[\s\S]*?) on.*?\=(['""])[\s\S]*?\2([\s\S]*?>)",
                            delegate (Match match)
                            {
                                return String.Concat(match.Groups[1].Value, match.Groups[3].Value);
                            }, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        }

        return returnVal;
    }

    public static string DataTableToCSV(DataTable datatable, char seperator)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < datatable.Columns.Count; i++)
        {
            sb.Append(datatable.Columns[i]);
            if (i < datatable.Columns.Count - 1)
                sb.Append(seperator);
        }
        sb.AppendLine();
        foreach (DataRow dr in datatable.Rows)
        {
            for (int i = 0; i < datatable.Columns.Count; i++)
            {
                sb.Append(dr[i].ToString());

                if (i < datatable.Columns.Count - 1)
                    sb.Append(seperator);
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }

    #region Event DateTime Management

    public static T GetEventTime<T>(DateTime startDateTime, DateTime endDatetime, int eventType, string zoneCode)
    {
        T objResult = default(T);
        dynamic tempObjResult = new System.Dynamic.ExpandoObject();
        try
        {
            DateTime tzStartDateTime, tzEndDateTime, tzCurrentTime;

            tzStartDateTime = startDateTime;
            tzEndDateTime = endDatetime;

            if (!string.IsNullOrEmpty(zoneCode))
            {
                TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(zoneCode);
                tzCurrentTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, tz);
                tz = null;
            }
            else
            {
                tzStartDateTime = startDateTime.ToUniversalTime();
                tzEndDateTime = endDatetime.ToUniversalTime();
                tzCurrentTime = DateTime.UtcNow;
            }

            switch (eventType)
            {
                case 1://Daily
                case 3://Weekly
                    EventStartEndDate objEventDate = GetEventStartEndDay(startDateTime, endDatetime, tzCurrentTime, (eventType == 1 ? 1 : 7));
                    if (objEventDate != null)
                    {
                        startDateTime = objEventDate.StartDate;
                        endDatetime = objEventDate.EndDate;
                        tzStartDateTime = startDateTime;
                        tzEndDateTime = endDatetime;
                    }
                    break;
            }

            int getEventEndDiff = DateTime.Compare(tzEndDateTime, tzCurrentTime);

            string dateFormat = tzStartDateTime.Date != tzEndDateTime.Date ? "multi" : "single";

            bool isStraddle = false;
            if (dateFormat.Equals("multi") && (startDateTime.Year != endDatetime.Year))
            {
                isStraddle = true;
            }

            if (getEventEndDiff <= 0)
            {
                //Event Happened
                if (dateFormat.Equals("single"))
                {
                    tempObjResult.Format_1 = FormatEventDate(startDateTime, 1, isStraddle);
                    tempObjResult.Format_2 = tempObjResult.Format_1;
                    tempObjResult.Format_3 = FormatEventDate(startDateTime, 2, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                    tempObjResult.Format_7 = FormatEventDate(startDateTime, 8, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                }
                else
                {
                    tempObjResult.Format_1 = FormatEventDate(startDateTime, 1, isStraddle) + " - " + FormatEventDate(endDatetime, 1, isStraddle);
                    tempObjResult.Format_2 = tempObjResult.Format_1;
                    tempObjResult.Format_3 = FormatEventDate(startDateTime, 2, isStraddle) + " - " + FormatEventDate(endDatetime, 2, isStraddle);
                    tempObjResult.Format_7 = FormatEventDate(startDateTime, 6, isStraddle) + " - " + FormatEventDate(endDatetime, 6, isStraddle);
                }

                int years, months, days, hours, minutes, seconds, milliseconds;
                GetElapsedTime(tzEndDateTime, tzCurrentTime, out years, out months, out days, out hours, out minutes, out seconds, out milliseconds);

                if (years == 0 && months == 0 && days == 0 && hours == 0 && minutes < 60)//minutes
                {
                    if (minutes <= 1)
                    {
                        tempObjResult.Format_4 = "Happened 1 minute";
                    }
                    else
                    {
                        tempObjResult.Format_4 = "Happened " + minutes + " minutes";
                    }

                    tempObjResult.Format_4 += " ago";
                }
                else if (years == 0 && months == 0 && days == 0 && hours < 24)//hours
                {

                    if (hours <= 1)
                    {
                        tempObjResult.Format_4 = "Happened 1 hour";
                    }
                    else
                    {
                        tempObjResult.Format_4 = "Happened " + hours + " hours";
                    }

                    if (minutes > 0)
                    {
                        if (minutes <= 1)
                        {
                            tempObjResult.Format_4 += " 1 minute";
                        }
                        else
                        {
                            tempObjResult.Format_4 += " " + minutes + " minutes";
                        }
                    }

                    tempObjResult.Format_4 += " ago";
                }
                else if (tzCurrentTime.AddDays(-1).Date == tzEndDateTime.Date)//yesterday
                {
                    tempObjResult.Format_4 = "Happened yesterday";
                }
                else if (years == 0 && months == 0 && days < 30)//with in 30 days
                {
                    if (days <= 1)
                    {
                        tempObjResult.Format_4 = "Happened 1 day";
                    }
                    else
                    {
                        tempObjResult.Format_4 = "Happened " + days + " days";
                    }

                    if (hours > 0)
                    {
                        if (hours <= 1)
                        {
                            tempObjResult.Format_4 += " 1 hour";
                        }
                        else
                        {
                            tempObjResult.Format_4 += " " + hours + " hours";
                        }
                    }

                    if (minutes > 0)
                    {
                        if (minutes <= 1)
                        {
                            tempObjResult.Format_4 += " 1 minute";
                        }
                        else
                        {
                            tempObjResult.Format_4 += " " + minutes + " minutes";
                        }
                    }

                    tempObjResult.Format_4 += " ago";

                }
                else if (years == 0 && months < 12)//with in month
                {
                    if (months <= 1)
                    {
                        tempObjResult.Format_4 = "Happened 1 month";
                    }
                    else
                    {
                        tempObjResult.Format_4 = "Happened " + months + " months";
                    }

                    if (days > 0)
                    {
                        if (days <= 1)
                        {
                            tempObjResult.Format_4 += " 1 day";
                        }
                        else
                        {
                            tempObjResult.Format_4 += " " + days + " days";
                        }
                    }

                    tempObjResult.Format_4 += " ago";
                }
                else //with in year
                {
                    if (years <= 1)
                    {
                        tempObjResult.Format_4 = "Happened 1 year";
                    }
                    else
                    {
                        tempObjResult.Format_4 = "Happened " + years + " years";
                    }

                    if (months > 0)
                    {
                        if (months <= 1)
                        {
                            tempObjResult.Format_4 += " 1 month";
                        }
                        else
                        {
                            tempObjResult.Format_4 += " " + months + " months";
                        }
                    }

                    if (days > 0)
                    {
                        if (days <= 1)
                        {
                            tempObjResult.Format_4 += " 1 day";
                        }
                        else
                        {
                            tempObjResult.Format_4 += " " + days + " days";
                        }
                    }
                    tempObjResult.Format_4 += " ago";
                }
            }
            else
            {
                int getEventStartDiff = DateTime.Compare(tzStartDateTime, tzCurrentTime);

                if (getEventStartDiff <= 0)
                {
                    //Happening Now
                    if (dateFormat.Equals("single"))
                    {
                        tempObjResult.Format_1 = "Happening now";
                        tempObjResult.Format_2 = "Today, " + FormatEventDate(startDateTime, 3, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                        tempObjResult.Format_3 = tempObjResult.Format_2;
                        tempObjResult.Format_7 = FormatEventDate(startDateTime, 8, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                    }
                    else
                    {
                        tempObjResult.Format_1 = FormatEventDate(startDateTime, 5, isStraddle) + " - " + FormatEventDate(endDatetime, 5, isStraddle);
                        tempObjResult.Format_2 = tempObjResult.Format_1;
                        tempObjResult.Format_3 = FormatEventDate(startDateTime, 6, isStraddle) + " - " + FormatEventDate(endDatetime, 6, isStraddle);
                        tempObjResult.Format_7 = FormatEventDate(startDateTime, 6, isStraddle) + " - " + FormatEventDate(endDatetime, 6, isStraddle);
                    }
                    tempObjResult.Format_4 = "Happening now";
                }
                else
                {
                    int years, months, days, hours, minutes, seconds, milliseconds;
                    GetElapsedTime(tzCurrentTime, tzStartDateTime, out years, out months, out days, out hours, out minutes, out seconds, out milliseconds);

                    List<DateTime> arrWeekDays = GetWeekDays(tzStartDateTime.Date);

                    if (tzCurrentTime.Date == tzStartDateTime.Date) //Same Day
                    {
                        if (dateFormat.Equals("single"))
                        {
                            tempObjResult.Format_1 = "Today &bull; " + FormatEventDate(startDateTime, 4, isStraddle);
                            tempObjResult.Format_2 = "Today, " + FormatEventDate(startDateTime, 3, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                            tempObjResult.Format_3 = tempObjResult.Format_2;
                            tempObjResult.Format_7 = FormatEventDate(startDateTime, 8, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                        }
                        else
                        {
                            tempObjResult.Format_1 = FormatEventDate(startDateTime, 5, isStraddle) + " - " + FormatEventDate(endDatetime, 5, isStraddle);
                            tempObjResult.Format_2 = tempObjResult.Format_1;
                            tempObjResult.Format_3 = FormatEventDate(startDateTime, 6, isStraddle) + " - " + FormatEventDate(endDatetime, 6, isStraddle);
                            tempObjResult.Format_7 = FormatEventDate(startDateTime, 6, isStraddle) + " - " + FormatEventDate(endDatetime, 6, isStraddle);
                        }

                        if (hours == 0 && minutes < 60)//within minutes
                        {
                            if (minutes <= 1)
                            {
                                tempObjResult.Format_4 = "Starts in 1 minute";
                            }
                            else
                            {
                                tempObjResult.Format_4 = "Starts in " + minutes + " minutes";
                            }
                        }
                        else //within hours
                        {
                            if (hours <= 1)
                            {
                                tempObjResult.Format_4 = "Starts in 1 hour";
                            }
                            else
                            {
                                tempObjResult.Format_4 = "Starts in " + hours + " hours";
                            }

                            if (minutes > 0)
                            {
                                if (minutes <= 1)
                                {
                                    tempObjResult.Format_4 += " 1 minute";
                                }
                                else
                                {
                                    tempObjResult.Format_4 += " " + minutes + " minutes";
                                }
                            }
                        }

                    }
                    else if (tzCurrentTime.AddDays(1).Date == tzStartDateTime.Date)//Tomorrow
                    {
                        if (dateFormat.Equals("single"))
                        {
                            tempObjResult.Format_1 = "Tomorrow &bull; " + FormatEventDate(startDateTime, 4, isStraddle);
                            tempObjResult.Format_2 = "Tomorrow, " + FormatEventDate(startDateTime, 3, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                            tempObjResult.Format_3 = tempObjResult.Format_2;
                            tempObjResult.Format_7 = FormatEventDate(startDateTime, 8, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                        }
                        else
                        {
                            tempObjResult.Format_1 = FormatEventDate(startDateTime, 5, isStraddle) + " - " + FormatEventDate(endDatetime, 5, isStraddle);
                            tempObjResult.Format_2 = tempObjResult.Format_1;
                            tempObjResult.Format_3 = FormatEventDate(startDateTime, 6, isStraddle) + " - " + FormatEventDate(endDatetime, 6, isStraddle);
                            tempObjResult.Format_7 = FormatEventDate(startDateTime, 6, isStraddle) + " - " + FormatEventDate(endDatetime, 6, isStraddle);
                        }
                        tempObjResult.Format_4 = "Starts tomorrow";
                    }
                    else if (arrWeekDays.Contains(tzCurrentTime.Date))//within same week
                    {
                        if (dateFormat.Equals("single"))
                        {
                            tempObjResult.Format_1 = FormatEventDate(startDateTime, 7, isStraddle);
                            tempObjResult.Format_2 = FormatEventDate(startDateTime, 8, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                            tempObjResult.Format_3 = tempObjResult.Format_2;
                            tempObjResult.Format_7 = FormatEventDate(startDateTime, 8, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                        }
                        else
                        {
                            tempObjResult.Format_1 = FormatEventDate(startDateTime, 5, isStraddle) + " - " + FormatEventDate(endDatetime, 5, isStraddle);
                            tempObjResult.Format_2 = tempObjResult.Format_1;
                            tempObjResult.Format_3 = FormatEventDate(startDateTime, 6, isStraddle) + " - " + FormatEventDate(endDatetime, 6, isStraddle);
                            tempObjResult.Format_7 = FormatEventDate(startDateTime, 6, isStraddle) + " - " + FormatEventDate(endDatetime, 6, isStraddle);
                        }

                        tempObjResult.Format_4 = "Starts this " + startDateTime.DayOfWeek.ToString();
                    }
                    else if (years == 0 && months == 0 && days < 30)//with in 30 days
                    {
                        if (dateFormat.Equals("single"))
                        {
                            tempObjResult.Format_1 = FormatEventDate(startDateTime, 7, isStraddle);
                            tempObjResult.Format_2 = FormatEventDate(startDateTime, 8, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                            tempObjResult.Format_3 = tempObjResult.Format_2;
                            tempObjResult.Format_7 = FormatEventDate(startDateTime, 8, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                        }
                        else
                        {
                            tempObjResult.Format_1 = FormatEventDate(startDateTime, 5, isStraddle) + " - " + FormatEventDate(endDatetime, 5, isStraddle);
                            tempObjResult.Format_2 = tempObjResult.Format_1;
                            tempObjResult.Format_3 = FormatEventDate(startDateTime, 6, isStraddle) + " - " + FormatEventDate(endDatetime, 6, isStraddle);
                            tempObjResult.Format_7 = FormatEventDate(startDateTime, 6, isStraddle) + " - " + FormatEventDate(endDatetime, 6, isStraddle);
                        }

                        if (days <= 1)
                        {
                            tempObjResult.Format_4 = "Starts in 1 day";
                        }
                        else
                        {
                            tempObjResult.Format_4 = "Starts in " + days + " days";
                        }

                        if (hours > 0)
                        {
                            if (hours <= 1)
                            {
                                tempObjResult.Format_4 += " 1 hour";
                            }
                            else
                            {
                                tempObjResult.Format_4 += " " + hours + " hours";
                            }
                        }

                        if (minutes > 0)
                        {
                            if (minutes <= 1)
                            {
                                tempObjResult.Format_4 += " 1 minute";
                            }
                            else
                            {
                                tempObjResult.Format_4 += " " + minutes + " minutes";
                            }
                        }

                    }
                    else if (years == 0 && months < 12)//with in month
                    {
                        if (dateFormat.Equals("single"))
                        {
                            tempObjResult.Format_1 = FormatEventDate(startDateTime, 7, isStraddle);
                            tempObjResult.Format_2 = FormatEventDate(startDateTime, 8, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                            tempObjResult.Format_3 = tempObjResult.Format_2;
                            tempObjResult.Format_7 = FormatEventDate(startDateTime, 8, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                        }
                        else
                        {
                            tempObjResult.Format_1 = FormatEventDate(startDateTime, 5, isStraddle) + " - " + FormatEventDate(endDatetime, 5, isStraddle);
                            tempObjResult.Format_2 = tempObjResult.Format_1;
                            tempObjResult.Format_3 = FormatEventDate(startDateTime, 6, isStraddle) + " - " + FormatEventDate(endDatetime, 6, isStraddle);
                            tempObjResult.Format_7 = FormatEventDate(startDateTime, 6, isStraddle) + " - " + FormatEventDate(endDatetime, 6, isStraddle);
                        }

                        if (months <= 1)
                        {
                            tempObjResult.Format_4 = "Starts in 1 month";
                        }
                        else
                        {
                            tempObjResult.Format_4 = "Starts in " + months + " months";
                        }

                        if (days > 0)
                        {
                            if (days <= 1)
                            {
                                tempObjResult.Format_4 += " 1 day";
                            }
                            else
                            {
                                tempObjResult.Format_4 += " " + days + " days";
                            }
                        }
                    }
                    else //with in year
                    {
                        if (dateFormat.Equals("single"))
                        {
                            tempObjResult.Format_1 = FormatEventDate(startDateTime, 1, isStraddle);
                            tempObjResult.Format_2 = FormatEventDate(startDateTime, 9, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                            tempObjResult.Format_3 = tempObjResult.Format_2;
                            tempObjResult.Format_7 = FormatEventDate(startDateTime, 8, isStraddle) + " - " + FormatEventDate(endDatetime, 4, isStraddle);
                        }
                        else
                        {
                            tempObjResult.Format_1 = FormatEventDate(startDateTime, 1, isStraddle) + " - " + FormatEventDate(endDatetime, 1, isStraddle);
                            tempObjResult.Format_2 = tempObjResult.Format_1;
                            tempObjResult.Format_3 = FormatEventDate(startDateTime, 2, isStraddle) + " - " + FormatEventDate(endDatetime, 2, isStraddle);
                            tempObjResult.Format_7 = FormatEventDate(startDateTime, 6, isStraddle) + " - " + FormatEventDate(endDatetime, 6, isStraddle);
                        }

                        if (years <= 1)
                        {
                            tempObjResult.Format_4 = "Starts in 1 year";
                        }
                        else
                        {
                            tempObjResult.Format_4 = "Starts in " + years + " years";
                        }

                        if (months > 0)
                        {
                            if (months <= 1)
                            {
                                tempObjResult.Format_4 += " 1 month";
                            }
                            else
                            {
                                tempObjResult.Format_4 += " " + months + " months";
                            }
                        }

                        if (days > 0)
                        {
                            if (days <= 1)
                            {
                                tempObjResult.Format_4 += " 1 day";
                            }
                            else
                            {
                                tempObjResult.Format_4 += " " + days + " days";
                            }
                        }
                    }
                }
            }

            tempObjResult.Format_5 = startDateTime.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");

            tempObjResult.Format_6 = FormatEventDate(startDateTime, 10, false);

            objResult = JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(tempObjResult));
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return objResult;
    }

    public static string FormatEventDate(DateTime date, int format, bool isStraddle)
    {
        string result = "";

        try
        {
            switch (format)
            {
                case 1:
                    if (date.Year != DateTime.UtcNow.Year || isStraddle)
                    {
                        result = date.Day.ToString() + " " + date.ToString("MMM") + " " + date.Year.ToString();
                    }
                    else
                    {
                        result = date.Day.ToString() + " " + date.ToString("MMM");
                    }
                    break;
                case 2:
                    if (date.Year != DateTime.UtcNow.Year || isStraddle)
                    {
                        result = date.Day.ToString() + " " + date.ToString("MMM") + " " + date.Year.ToString() + ", " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                    }
                    else
                    {
                        result = date.Day.ToString() + " " + date.ToString("MMM") + ", " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                    }
                    break;
                case 3:
                    if (date.Year != DateTime.UtcNow.Year || isStraddle)
                    {
                        result = date.Day.ToString() + " " + date.ToString("MMM") + " " + date.Year.ToString() + " at " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                    }
                    else
                    {
                        result = date.Day.ToString() + " " + date.ToString("MMM") + " at " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                    }
                    break;
                case 4:
                    result = date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                    break;
                case 5:
                    if (date.Year != DateTime.UtcNow.Year || isStraddle)
                    {
                        result = date.Day.ToString() + " " + date.ToString("MMM") + " " + date.Year.ToString();
                    }
                    else
                    {
                        result = date.Day.ToString() + " " + date.ToString("MMM");
                    }
                    break;
                case 6:
                    if (date.Year != DateTime.UtcNow.Year || isStraddle)
                    {
                        result = date.Day.ToString() + " " + date.ToString("MMM") + " " + date.Year.ToString() + ", " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                    }
                    else
                    {
                        result = date.Day.ToString() + " " + date.ToString("MMM") + ", " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                    }
                    break;
                case 7:
                    if (date.Year != DateTime.UtcNow.Year || isStraddle)
                    {
                        result = date.ToString("ddd") + ", " + date.Day.ToString() + " " + date.ToString("MMM") + " " + date.Year.ToString() + " &bull; " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                    }
                    else
                    {
                        result = date.ToString("ddd") + ", " + date.Day.ToString() + " " + date.ToString("MMM") + " &bull; " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                    }

                    break;
                case 8:
                    if (date.Year != DateTime.UtcNow.Year || isStraddle)
                    {
                        result = date.ToString("ddd") + ", " + date.Day.ToString() + " " + date.ToString("MMM") + " " + date.Year.ToString() + " at " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                    }
                    else
                    {
                        result = date.ToString("ddd") + ", " + date.Day.ToString() + " " + date.ToString("MMM") + " at " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                    }
                    break;
                case 9:
                    result = date.ToString("ddd") + ", " + date.Day.ToString() + " " + date.ToString("MMM") + " " + date.Year.ToString() + " at " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                    break;
                case 10:
                    if (date.Year != DateTime.UtcNow.Year)
                    {
                        result = date.ToString("ddd") + ", " + date.Day.ToString() + " " + date.ToString("MMM") + " " + date.Year.ToString();
                    }
                    else
                    {
                        result = date.ToString("ddd") + ", " + date.Day.ToString() + " " + date.ToString("MMM");
                    }
                    break;
                case 11:
                    if (date.Year != DateTime.UtcNow.Year)
                    {
                        result = date.Day.ToString("00") + " " + date.ToString("MMM") + " " + date.Year.ToString();
                    }
                    else
                    {
                        result = date.Day.ToString("00") + " " + date.ToString("MMM") + " at " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                    }
                    break;
                case 12:
                    result = date.ToString("dddd") + ", " + date.Day.ToString() + " " + date.ToString("MMMM") + " " + date.Year + " at " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00");
                    break;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }

        return result;
    }

    public static List<DateTime> GetWeekDays(DateTime dt)
    {
        List<DateTime> lstDT = new List<DateTime>();
        try
        {
            List<string> arrWeekDays = new List<string> { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
            string dtWeekDay = dt.DayOfWeek.ToString().ToLower();
            int dtWeekPosition = arrWeekDays.IndexOf(dtWeekDay);
            for (int i = 0; i < 7; i++)
            {
                if (i < dtWeekPosition)
                {
                    lstDT.Add(dt.AddDays(i - dtWeekPosition).Date);
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return lstDT;
    }

    public static EventStartEndDate GetEventStartEndDay(DateTime startDate, DateTime endDate, DateTime currDate, int dayDiff)
    {
        EventStartEndDate objResult = null;
        try
        {
            DateTime startDatePart = startDate.Date;
            TimeSpan startTimePart = startDate.TimeOfDay;

            DateTime endDatePart = endDate.Date;
            TimeSpan endTimePart = endDate.TimeOfDay;

            List<EventStartEndDate> lstOfEventDate = new List<EventStartEndDate>();

            do
            {
                EventStartEndDate objEventDate = new EventStartEndDate();
                objEventDate.StartDate = startDatePart.Add(startTimePart);
                objEventDate.EndDate = startDatePart.Add(endTimePart);

                lstOfEventDate.Add(objEventDate);
                objEventDate = null;

                startDatePart = startDatePart.AddDays(dayDiff);

            } while (DateTime.Compare(startDatePart, endDatePart) <= 0);

            if (lstOfEventDate.Count > 0)
            {
                foreach (EventStartEndDate objEvent in lstOfEventDate)
                {
                    if (objResult == null)
                    {
                        if (DateTime.Compare(currDate, objEvent.EndDate) <= 0)
                        {
                            objResult = objEvent;
                        }
                    }
                }

                if (objResult == null)
                {
                    objResult = lstOfEventDate[lstOfEventDate.Count - 1];
                }

            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return objResult;
    }

    public class EventStartEndDate
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public static void GetElapsedTime(DateTime from_date, DateTime to_date, out int years, out int months, out int days, out int hours, out int minutes, out int seconds, out int milliseconds)
    {
        // If from_date > to_date, switch them around.
        if (from_date > to_date)
        {
            GetElapsedTime(to_date, from_date,
                out years, out months, out days, out hours,
                out minutes, out seconds, out milliseconds);
            years = -years;
            months = -months;
            days = -days;
            hours = -hours;
            minutes = -minutes;
            seconds = -seconds;
            milliseconds = -milliseconds;
        }
        else
        {
            // Handle the years.
            years = to_date.Year - from_date.Year;

            // See if we went too far.
            DateTime test_date = from_date.AddMonths(12 * years);
            if (test_date > to_date)
            {
                years--;
                test_date = from_date.AddMonths(12 * years);
            }

            // Add months until we go too far.
            months = 0;
            while (test_date <= to_date)
            {
                months++;
                test_date = from_date.AddMonths(12 * years + months);
            }
            months--;

            // Subtract to see how many more days,
            // hours, minutes, etc. we need.
            from_date = from_date.AddMonths(12 * years + months);
            TimeSpan remainder = to_date - from_date;
            days = remainder.Days;
            hours = remainder.Hours;
            minutes = remainder.Minutes;
            seconds = remainder.Seconds;
            milliseconds = remainder.Milliseconds;
        }

        if (days == 31)
        {
            days = 0;
            months += 1;
        }
        if (months == 12)
        {
            months = 0;
            years += 1;
        }
    }

    public static string FormatPostDateTime(string postDate, bool isUTC, bool isSecond)
    {
        string datestring = "";
        DateTime date = Convert.ToDateTime(postDate);
        int currentYear = DateTime.UtcNow.Year;

        if (!isSecond)
        {
            datestring = date.ToString("ddd") + ", " + date.Day.ToString() + " " + date.ToString("MMM") + (date.Year == currentYear ? "" : " " + date.Year) + " at " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00") + ":" + date.Second.ToString("00");
        }
        else
        {
            datestring = date.ToString("ddd") + ", " + date.Day.ToString() + " " + date.ToString("MMM") + (date.Year == currentYear ? "" : " " + date.Year) + " at " + date.Hour.ToString("00") + ":" + date.Minute.ToString("00") + ":" + date.Second.ToString("00");
        }

        if (isUTC)
        {
            datestring += " UTC";
        }

        return datestring;
    }

    #endregion

    #region get location by ip address
    public static LocationByIP GetLocationByIPAddress(string ipAddress)
    {
        LocationByIP locationRes = new LocationByIP();
        string json = string.Empty;
        string APIKey = Convert.ToString(ConfigurationManager.AppSettings["LocDetectorByIPAPIKey"]);
        string ipDetails = ipAddress.Split(',')[0];
        string url = string.Format(Convert.ToString(ConfigurationManager.AppSettings["LocDetectorByIPAPIEndPoint"]) + "{0}?access_key={1}", ipDetails, APIKey);
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        using (WebClient client = new WebClient())
        {
            json = client.DownloadString(url);
            locationRes = new JavaScriptSerializer().Deserialize<LocationByIP>(json);
        }
        return locationRes;
    }

    public class LocationByIP
    {
        public string country_name { get; set; }
        public string country_code { get; set; }
        public string city { get; set; }
        public string region_name { get; set; }
        public string continent_name { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
    }

    public static string GetDeviceType(string userAgent)
    {
        string deviceType = "";
        if (!string.IsNullOrEmpty(userAgent))
        {
            userAgent = userAgent.ToLower();
            if (userAgent.Contains("iphone"))
            {
                deviceType = "iPhone";
            }
            else if (userAgent.Contains("ipad"))
            {
                deviceType = "iPad";
            }
            else if (userAgent.Contains("mobile"))
            {
                deviceType = "Mobile Phone";
            }
            else if (userAgent.Contains("mac"))
            {
                deviceType = "Mac";
            }
            else if (userAgent.Contains("windows"))
            {
                deviceType = "Windows";
            }
        }
        return deviceType;
    }

    public static string GetIPDetails()
    {
        //IP Details:HostName,RemoteIP,LocalIP
        string ipDetails = "";
        try
        {
            //Find IP Address Behind Proxy Or Client Machine In ASP.NET
            string visitorIPAddress = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (String.IsNullOrEmpty(visitorIPAddress))
                visitorIPAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

            if (string.IsNullOrEmpty(visitorIPAddress))
                visitorIPAddress = HttpContext.Current.Request.UserHostAddress;

            ipDetails = visitorIPAddress;
        }
        catch (Exception)
        {
            ipDetails = "";
        }
        return ipDetails;
    }

    public static string GetClientIPAddress()
    {
        string ipaddress;
        ipaddress = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (ipaddress == "" || ipaddress == null)
            ipaddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
        return ipaddress;
    }


    #endregion

    public static double GetCoordinateDouble(PropertyItem propItem)
    {
        uint degreesNumerator = BitConverter.ToUInt32(propItem.Value, 0);
        uint degreesDenominator = BitConverter.ToUInt32(propItem.Value, 4);
        double degrees = degreesNumerator / (double)degreesDenominator;


        uint minutesNumerator = BitConverter.ToUInt32(propItem.Value, 8);
        uint minutesDenominator = BitConverter.ToUInt32(propItem.Value, 12);
        double minutes = minutesNumerator / (double)minutesDenominator;

        uint secondsNumerator = BitConverter.ToUInt32(propItem.Value, 16);
        uint secondsDenominator = BitConverter.ToUInt32(propItem.Value, 20);
        double seconds = secondsNumerator / (double)secondsDenominator;

        double coorditate = degrees + (minutes / 60d) + (seconds / 3600d);
        string gpsRef = Encoding.ASCII.GetString(new byte[1] { propItem.Value[0] }); //N, S, E, or W  

        if (gpsRef == "S" || gpsRef == "W") coorditate = coorditate * -1;
        return coorditate;
    }

    public static DataTable ToDataTable<T>(List<T> items)
    {
        DataTable dataTable = new DataTable(typeof(T).Name);

        //Get all the properties
        PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (PropertyInfo prop in Props)
        {
            //Defining type of data column gives proper data table 
            var type = (prop.PropertyType.IsGenericType &&
                        prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>)
                ? Nullable.GetUnderlyingType(prop.PropertyType)
                : prop.PropertyType);
            //Setting column names as Property names
            dataTable.Columns.Add(prop.Name, type);
        }

        foreach (T item in items)
        {
            var values = new object[Props.Length];
            for (int i = 0; i < Props.Length; i++)
                //inserting property values to datatable rows
                values[i] = Props[i].GetValue(item, null);
            dataTable.Rows.Add(values);
        }

        //put a breakpoint here and check datatable
        return dataTable;
    }

    //public static string GetAPIData(string Url, string data, string requestMethod = "POST", bool isGetQuerystring = true)
    //{
    //    string content = "";
    //    try
    //    {
    //        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
    //        if (requestMethod.Equals("get", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var requestMessage = new HttpRequestMessage
    //            {
    //                Method = HttpMethod.Get
    //            };
    //            if (isGetQuerystring)
    //            {
    //                requestMessage.RequestUri = new Uri(Url + "?" + data);
    //            }
    //            else
    //            {
    //                requestMessage.RequestUri = new Uri(Url);
    //                requestMessage.Content = new StringContent(data);
    //            }

    //            //Request Token
    //            using (var client = isGetQuerystring? new HttpClient() : new HttpClient(handler))
    //            {
    //                //var request = client.SendAsync(requestMessage).Result;
    //                //content = request.Content.ReadAsStringAsync().Result;

    //                var response = client.SendAsync(requestMessage).ConfigureAwait(false);

    //                var responseInfo = response.GetAwaiter().GetResult();
    //            }
    //        }
    //        else
    //        {
    //            var http = (HttpWebRequest)WebRequest.Create(new Uri(Url));
    //            http.Method = requestMethod;
    //            http.Accept = "application/json";
    //            http.ContentType = "application/json";
    //            ASCIIEncoding encoding = new ASCIIEncoding();
    //            Byte[] bytes = encoding.GetBytes(data);

    //            Stream newStream = http.GetRequestStream();
    //            newStream.Write(bytes, 0, bytes.Length);
    //            newStream.Close();

    //            var response = http.GetResponse();

    //            var stream = response.GetResponseStream();
    //            var sr = new StreamReader(stream);
    //            content = sr.ReadToEnd();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        new LogHandler().Debug(Logtype.DEBUG, ApplicationType.MVCAPI, "Common", "GetAPIData", ex.ToString() + ", URL: " + Url + ", " + data, "");
    //    }
    //    return content;

    //}


    public static string GetAPIData(string Url, string data, string requestMethod = "POST", bool isGetQuerystring = true)
    {
        string content = "";
        try
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            var httpRequest = (HttpWebRequest)WebRequest.Create(new Uri(Url));
            httpRequest.ContentType = "application/json";
            httpRequest.Method = requestMethod;

            if (requestMethod.Equals("get", StringComparison.OrdinalIgnoreCase))
            {
                if (isGetQuerystring)
                {
                    var requestMessage = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get
                    };
                    requestMessage.RequestUri = new Uri(Url + "?" + data);


                    using (var client = new HttpClient())
                    {
                        var request = client.SendAsync(requestMessage).Result;
                        content = request.Content.ReadAsStringAsync().Result;
                    }
                }
                else
                {
                    var type = httpRequest.GetType();
                    var currentMethod = type.GetProperty("CurrentMethod", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(httpRequest);

                    var methodType = currentMethod.GetType();
                    methodType.GetField("ContentBodyNotAllowed", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(currentMethod, false);

                    using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                    {
                        streamWriter.Write(data);
                    }

                    using(var response = httpRequest.GetResponse())
                    {
                        var stream = response.GetResponseStream();
                        var sr = new StreamReader(stream);
                        content = sr.ReadToEnd();
                    }                    
                }
            }
            else
            {
                httpRequest.Accept = "application/json";
                ASCIIEncoding encoding = new ASCIIEncoding();
                Byte[] bytes = encoding.GetBytes(data);

                using (Stream streamWriter = httpRequest.GetRequestStream())
                {
                    streamWriter.Write(bytes, 0, bytes.Length);
                }

                using (var response = httpRequest.GetResponse())
                {
                    var stream = response.GetResponseStream();
                    var sr = new StreamReader(stream);
                    content = sr.ReadToEnd();
                }
            }
        }
        catch (Exception ex)
        {
            
        }
        return content;
    }


    public static string DeleteAPIData(string Url, string data)
    {
        string content = "";
        try
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            var http = (HttpWebRequest)WebRequest.Create(new Uri(Url));
            http.Accept = "application/json";
            http.ContentType = "application/json";
            http.Method = "DELETE";

            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] bytes = encoding.GetBytes(data);

            Stream newStream = http.GetRequestStream();
            newStream.Write(bytes, 0, bytes.Length);
            newStream.Close();

            var response = http.GetResponse();

            var stream = response.GetResponseStream();
            var sr = new StreamReader(stream);
            content = sr.ReadToEnd();
        }
        catch (Exception ex)
        {
            
        }
        return content;

    }

   
    public static string RemoveEscapeChar(string text)
    {
        string[] arrayReplaceCharacter = new string[] { "\"", "'", "<", ">", "/", "&", "’" };
        int currentPostion = 0;
        foreach (string replaceCharacter in arrayReplaceCharacter)
        {
            text = text.Replace(arrayReplaceCharacter[currentPostion], "");
            currentPostion++;
        }
        return text;
    }

    public static string GuessDateTimePattern(string text, CultureInfo culture)
    {
        foreach (var pattern in GetDateTimePatterns(culture))
        {
            DateTime ignored;
            if (DateTime.TryParseExact(text, pattern, culture,
                                       DateTimeStyles.None, out ignored))
            {
                return pattern;
            }
        }
        return null;
    }

    private static IList<string> GetDateTimePatterns(CultureInfo culture)
    {
        var info = culture.DateTimeFormat;
        return new string[]
        {
            "dd-MM-yyyy HH:mm",
            info.FullDateTimePattern,
            info.LongDatePattern  + " " + info.ShortTimePattern,
            info.ShortDatePattern + " " + info.ShortTimePattern,
            info.ShortDatePattern + " " + info.LongTimePattern,
            info.ShortDatePattern + " " + info.ShortTimePattern,
            info.SortableDateTi­mePattern,
            info.UniversalSorta­bleDateTimePat­tern,

        };
    }


    #region Get words for URL
    public static string ProductPageUrl(string mainString, string tsin = "", bool isEncode = false)
    {
        return (Convert.ToString(ConfigurationManager.AppSettings["webDomain"]) + GetWordsForURL(mainString, isEncode) + "/pdp/" + tsin);
    }

    public static string GetWordsForURL(string mainString, bool isEncode = false)
    {
        string urlwords = "";
        if (!string.IsNullOrEmpty(mainString))
        {
            mainString = Common.HtmlDecode(mainString).ToLower();
            mainString = RemoveEmoji(mainString);
            if (!string.IsNullOrEmpty(mainString))
            {
                mainString = RemoveStopWord(mainString);
                if (!string.IsNullOrEmpty(mainString))
                {
                    string joinstring = mainString.Replace(" ", "-");
                    joinstring = Common.UrlCompatibleString(joinstring);
                    if (!string.IsNullOrEmpty(joinstring))
                    {
                        IEnumerable<string> joinstring2 = joinstring.Split('-').Take(7);
                        urlwords = string.Join("-", joinstring2.ToArray());
                        if (isEncode)
                        {
                            urlwords = HttpUtility.UrlEncode(urlwords);
                        }
                    }
                }
            }
        }
        return urlwords;
    }

    public static string RemoveEmoji(string MainString)
    {
        return Regex.Replace(MainString, @"[#*0-9]\uFE0F?\u20E3|©\uFE0F?|[®\u203C\u2049\u2122\u2139\u2194-\u2199\u21A9\u21AA]\uFE0F?|[\u231A\u231B]|[\u2328\u23CF]\uFE0F?|[\u23E9-\u23EC]|[\u23ED-\u23EF]\uFE0F?|\u23F0|[\u23F1\u23F2]\uFE0F?|\u23F3|[\u23F8-\u23FA\u24C2\u25AA\u25AB\u25B6\u25C0\u25FB\u25FC]\uFE0F?|[\u25FD\u25FE]|[\u2600-\u2604\u260E\u2611]\uFE0F?|[\u2614\u2615]|\u2618\uFE0F?|\u261D(?:\uD83C[\uDFFB-\uDFFF]|\uFE0F)?|[\u2620\u2622\u2623\u2626\u262A\u262E\u262F\u2638-\u263A\u2640\u2642]\uFE0F?|[\u2648-\u2653]|[\u265F\u2660\u2663\u2665\u2666\u2668\u267B\u267E]\uFE0F?|\u267F|\u2692\uFE0F?|\u2693|[\u2694-\u2697\u2699\u269B\u269C\u26A0]\uFE0F?|\u26A1|\u26A7\uFE0F?|[\u26AA\u26AB]|[\u26B0\u26B1]\uFE0F?|[\u26BD\u26BE\u26C4\u26C5]|\u26C8\uFE0F?|\u26CE|[\u26CF\u26D1\u26D3]\uFE0F?|\u26D4|\u26E9\uFE0F?|\u26EA|[\u26F0\u26F1]\uFE0F?|[\u26F2\u26F3]|\u26F4\uFE0F?|\u26F5|[\u26F7\u26F8]\uFE0F?|\u26F9(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?|\uFE0F(?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\u26FA\u26FD]|\u2702\uFE0F?|\u2705|[\u2708\u2709]\uFE0F?|[\u270A\u270B](?:\uD83C[\uDFFB-\uDFFF])?|[\u270C\u270D](?:\uD83C[\uDFFB-\uDFFF]|\uFE0F)?|\u270F\uFE0F?|[\u2712\u2714\u2716\u271D\u2721]\uFE0F?|\u2728|[\u2733\u2734\u2744\u2747]\uFE0F?|[\u274C\u274E\u2753-\u2755\u2757]|\u2763\uFE0F?|\u2764(?:\u200D(?:\uD83D\uDD25|\uD83E\uDE79)|\uFE0F(?:\u200D(?:\uD83D\uDD25|\uD83E\uDE79))?)?|[\u2795-\u2797]|\u27A1\uFE0F?|[\u27B0\u27BF]|[\u2934\u2935\u2B05-\u2B07]\uFE0F?|[\u2B1B\u2B1C\u2B50\u2B55]|[\u3030\u303D\u3297\u3299]\uFE0F?|\uD83C(?:[\uDC04\uDCCF]|[\uDD70\uDD71\uDD7E\uDD7F]\uFE0F?|[\uDD8E\uDD91-\uDD9A]|\uDDE6\uD83C[\uDDE8-\uDDEC\uDDEE\uDDF1\uDDF2\uDDF4\uDDF6-\uDDFA\uDDFC\uDDFD\uDDFF]|\uDDE7\uD83C[\uDDE6\uDDE7\uDDE9-\uDDEF\uDDF1-\uDDF4\uDDF6-\uDDF9\uDDFB\uDDFC\uDDFE\uDDFF]|\uDDE8\uD83C[\uDDE6\uDDE8\uDDE9\uDDEB-\uDDEE\uDDF0-\uDDF5\uDDF7\uDDFA-\uDDFF]|\uDDE9\uD83C[\uDDEA\uDDEC\uDDEF\uDDF0\uDDF2\uDDF4\uDDFF]|\uDDEA\uD83C[\uDDE6\uDDE8\uDDEA\uDDEC\uDDED\uDDF7-\uDDFA]|\uDDEB\uD83C[\uDDEE-\uDDF0\uDDF2\uDDF4\uDDF7]|\uDDEC\uD83C[\uDDE6\uDDE7\uDDE9-\uDDEE\uDDF1-\uDDF3\uDDF5-\uDDFA\uDDFC\uDDFE]|\uDDED\uD83C[\uDDF0\uDDF2\uDDF3\uDDF7\uDDF9\uDDFA]|\uDDEE\uD83C[\uDDE8-\uDDEA\uDDF1-\uDDF4\uDDF6-\uDDF9]|\uDDEF\uD83C[\uDDEA\uDDF2\uDDF4\uDDF5]|\uDDF0\uD83C[\uDDEA\uDDEC-\uDDEE\uDDF2\uDDF3\uDDF5\uDDF7\uDDFC\uDDFE\uDDFF]|\uDDF1\uD83C[\uDDE6-\uDDE8\uDDEE\uDDF0\uDDF7-\uDDFB\uDDFE]|\uDDF2\uD83C[\uDDE6\uDDE8-\uDDED\uDDF0-\uDDFF]|\uDDF3\uD83C[\uDDE6\uDDE8\uDDEA-\uDDEC\uDDEE\uDDF1\uDDF4\uDDF5\uDDF7\uDDFA\uDDFF]|\uDDF4\uD83C\uDDF2|\uDDF5\uD83C[\uDDE6\uDDEA-\uDDED\uDDF0-\uDDF3\uDDF7-\uDDF9\uDDFC\uDDFE]|\uDDF6\uD83C\uDDE6|\uDDF7\uD83C[\uDDEA\uDDF4\uDDF8\uDDFA\uDDFC]|\uDDF8\uD83C[\uDDE6-\uDDEA\uDDEC-\uDDF4\uDDF7-\uDDF9\uDDFB\uDDFD-\uDDFF]|\uDDF9\uD83C[\uDDE6\uDDE8\uDDE9\uDDEB-\uDDED\uDDEF-\uDDF4\uDDF7\uDDF9\uDDFB\uDDFC\uDDFF]|\uDDFA\uD83C[\uDDE6\uDDEC\uDDF2\uDDF3\uDDF8\uDDFE\uDDFF]|\uDDFB\uD83C[\uDDE6\uDDE8\uDDEA\uDDEC\uDDEE\uDDF3\uDDFA]|\uDDFC\uD83C[\uDDEB\uDDF8]|\uDDFD\uD83C\uDDF0|\uDDFE\uD83C[\uDDEA\uDDF9]|\uDDFF\uD83C[\uDDE6\uDDF2\uDDFC]|\uDE01|\uDE02\uFE0F?|[\uDE1A\uDE2F\uDE32-\uDE36]|\uDE37\uFE0F?|[\uDE38-\uDE3A\uDE50\uDE51\uDF00-\uDF20]|[\uDF21\uDF24-\uDF2C]\uFE0F?|[\uDF2D-\uDF35]|\uDF36\uFE0F?|[\uDF37-\uDF7C]|\uDF7D\uFE0F?|[\uDF7E-\uDF84]|\uDF85(?:\uD83C[\uDFFB-\uDFFF])?|[\uDF86-\uDF93]|[\uDF96\uDF97\uDF99-\uDF9B\uDF9E\uDF9F]\uFE0F?|[\uDFA0-\uDFC1]|\uDFC2(?:\uD83C[\uDFFB-\uDFFF])?|[\uDFC3\uDFC4](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDFC5\uDFC6]|\uDFC7(?:\uD83C[\uDFFB-\uDFFF])?|[\uDFC8\uDFC9]|\uDFCA(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDFCB\uDFCC](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?|\uFE0F(?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDFCD\uDFCE]\uFE0F?|[\uDFCF-\uDFD3]|[\uDFD4-\uDFDF]\uFE0F?|[\uDFE0-\uDFF0]|\uDFF3(?:\u200D(?:\u26A7\uFE0F?|\uD83C\uDF08)|\uFE0F(?:\u200D(?:\u26A7\uFE0F?|\uD83C\uDF08))?)?|\uDFF4(?:\u200D\u2620\uFE0F?|\uDB40\uDC67\uDB40\uDC62\uDB40(?:\uDC65\uDB40\uDC6E\uDB40\uDC67|\uDC73\uDB40\uDC63\uDB40\uDC74|\uDC77\uDB40\uDC6C\uDB40\uDC73)\uDB40\uDC7F)?|[\uDFF5\uDFF7]\uFE0F?|[\uDFF8-\uDFFF])|\uD83D(?:[\uDC00-\uDC07]|\uDC08(?:\u200D\u2B1B)?|[\uDC09-\uDC14]|\uDC15(?:\u200D\uD83E\uDDBA)?|[\uDC16-\uDC3A]|\uDC3B(?:\u200D\u2744\uFE0F?)?|[\uDC3C-\uDC3E]|\uDC3F\uFE0F?|\uDC40|\uDC41(?:\u200D\uD83D\uDDE8\uFE0F?|\uFE0F(?:\u200D\uD83D\uDDE8\uFE0F?)?)?|[\uDC42\uDC43](?:\uD83C[\uDFFB-\uDFFF])?|[\uDC44\uDC45]|[\uDC46-\uDC50](?:\uD83C[\uDFFB-\uDFFF])?|[\uDC51-\uDC65]|[\uDC66\uDC67](?:\uD83C[\uDFFB-\uDFFF])?|\uDC68(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:\uDC8B\u200D\uD83D)?\uDC68|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D(?:\uDC66(?:\u200D\uD83D\uDC66)?|\uDC67(?:\u200D\uD83D[\uDC66\uDC67])?|[\uDC68\uDC69]\u200D\uD83D(?:\uDC66(?:\u200D\uD83D\uDC66)?|\uDC67(?:\u200D\uD83D[\uDC66\uDC67])?)|[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92])|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|\uD83C(?:\uDFFB(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:\uDC8B\u200D\uD83D)?\uDC68\uD83C[\uDFFB-\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D\uDC68\uD83C[\uDFFC-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFC(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:\uDC8B\u200D\uD83D)?\uDC68\uD83C[\uDFFB-\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D\uDC68\uD83C[\uDFFB\uDFFD-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFD(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:\uDC8B\u200D\uD83D)?\uDC68\uD83C[\uDFFB-\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D\uDC68\uD83C[\uDFFB\uDFFC\uDFFE\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFE(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:\uDC8B\u200D\uD83D)?\uDC68\uD83C[\uDFFB-\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D\uDC68\uD83C[\uDFFB-\uDFFD\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFF(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:\uDC8B\u200D\uD83D)?\uDC68\uD83C[\uDFFB-\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D\uDC68\uD83C[\uDFFB-\uDFFE]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?))?|\uDC69(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:\uDC8B\u200D\uD83D)?[\uDC68\uDC69]|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D(?:\uDC66(?:\u200D\uD83D\uDC66)?|\uDC67(?:\u200D\uD83D[\uDC66\uDC67])?|\uDC69\u200D\uD83D(?:\uDC66(?:\u200D\uD83D\uDC66)?|\uDC67(?:\u200D\uD83D[\uDC66\uDC67])?)|[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92])|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|\uD83C(?:\uDFFB(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF]|\uDC8B\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF])|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFC-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFC(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF]|\uDC8B\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF])|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB\uDFFD-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFD(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF]|\uDC8B\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF])|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB\uDFFC\uDFFE\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFE(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF]|\uDC8B\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF])|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFD\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFF(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF]|\uDC8B\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF])|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFE]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?))?|\uDC6A|[\uDC6B-\uDC6D](?:\uD83C[\uDFFB-\uDFFF])?|\uDC6E(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDC6F(?:\u200D[\u2640\u2642]\uFE0F?)?|[\uDC70\uDC71](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDC72(?:\uD83C[\uDFFB-\uDFFF])?|\uDC73(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDC74-\uDC76](?:\uD83C[\uDFFB-\uDFFF])?|\uDC77(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDC78(?:\uD83C[\uDFFB-\uDFFF])?|[\uDC79-\uDC7B]|\uDC7C(?:\uD83C[\uDFFB-\uDFFF])?|[\uDC7D-\uDC80]|[\uDC81\uDC82](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDC83(?:\uD83C[\uDFFB-\uDFFF])?|\uDC84|\uDC85(?:\uD83C[\uDFFB-\uDFFF])?|[\uDC86\uDC87](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDC88-\uDC8E]|\uDC8F(?:\uD83C[\uDFFB-\uDFFF])?|\uDC90|\uDC91(?:\uD83C[\uDFFB-\uDFFF])?|[\uDC92-\uDCA9]|\uDCAA(?:\uD83C[\uDFFB-\uDFFF])?|[\uDCAB-\uDCFC]|\uDCFD\uFE0F?|[\uDCFF-\uDD3D]|[\uDD49\uDD4A]\uFE0F?|[\uDD4B-\uDD4E\uDD50-\uDD67]|[\uDD6F\uDD70\uDD73]\uFE0F?|\uDD74(?:\uD83C[\uDFFB-\uDFFF]|\uFE0F)?|\uDD75(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?|\uFE0F(?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDD76-\uDD79]\uFE0F?|\uDD7A(?:\uD83C[\uDFFB-\uDFFF])?|[\uDD87\uDD8A-\uDD8D]\uFE0F?|\uDD90(?:\uD83C[\uDFFB-\uDFFF]|\uFE0F)?|[\uDD95\uDD96](?:\uD83C[\uDFFB-\uDFFF])?|\uDDA4|[\uDDA5\uDDA8\uDDB1\uDDB2\uDDBC\uDDC2-\uDDC4\uDDD1-\uDDD3\uDDDC-\uDDDE\uDDE1\uDDE3\uDDE8\uDDEF\uDDF3\uDDFA]\uFE0F?|[\uDDFB-\uDE2D]|\uDE2E(?:\u200D\uD83D\uDCA8)?|[\uDE2F-\uDE34]|\uDE35(?:\u200D\uD83D\uDCAB)?|\uDE36(?:\u200D\uD83C\uDF2B\uFE0F?)?|[\uDE37-\uDE44]|[\uDE45-\uDE47](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDE48-\uDE4A]|\uDE4B(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDE4C(?:\uD83C[\uDFFB-\uDFFF])?|[\uDE4D\uDE4E](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDE4F(?:\uD83C[\uDFFB-\uDFFF])?|[\uDE80-\uDEA2]|\uDEA3(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDEA4-\uDEB3]|[\uDEB4-\uDEB6](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDEB7-\uDEBF]|\uDEC0(?:\uD83C[\uDFFB-\uDFFF])?|[\uDEC1-\uDEC5]|\uDECB\uFE0F?|\uDECC(?:\uD83C[\uDFFB-\uDFFF])?|[\uDECD-\uDECF]\uFE0F?|[\uDED0-\uDED2\uDED5-\uDED7]|[\uDEE0-\uDEE5\uDEE9]\uFE0F?|[\uDEEB\uDEEC]|[\uDEF0\uDEF3]\uFE0F?|[\uDEF4-\uDEFC\uDFE0-\uDFEB])|\uD83E(?:\uDD0C(?:\uD83C[\uDFFB-\uDFFF])?|[\uDD0D\uDD0E]|\uDD0F(?:\uD83C[\uDFFB-\uDFFF])?|[\uDD10-\uDD17]|[\uDD18-\uDD1C](?:\uD83C[\uDFFB-\uDFFF])?|\uDD1D|[\uDD1E\uDD1F](?:\uD83C[\uDFFB-\uDFFF])?|[\uDD20-\uDD25]|\uDD26(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDD27-\uDD2F]|[\uDD30-\uDD34](?:\uD83C[\uDFFB-\uDFFF])?|\uDD35(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDD36(?:\uD83C[\uDFFB-\uDFFF])?|[\uDD37-\uDD39](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDD3A|\uDD3C(?:\u200D[\u2640\u2642]\uFE0F?)?|[\uDD3D\uDD3E](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDD3F-\uDD45\uDD47-\uDD76]|\uDD77(?:\uD83C[\uDFFB-\uDFFF])?|[\uDD78\uDD7A-\uDDB4]|[\uDDB5\uDDB6](?:\uD83C[\uDFFB-\uDFFF])?|\uDDB7|[\uDDB8\uDDB9](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDDBA|\uDDBB(?:\uD83C[\uDFFB-\uDFFF])?|[\uDDBC-\uDDCB]|[\uDDCD-\uDDCF](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDDD0|\uDDD1(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\uD83C[\uDF3E\uDF73\uDF7C\uDF84\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83E\uDDD1|[\uDDAF-\uDDB3\uDDBC\uDDBD]))|\uD83C(?:\uDFFB(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D(?:\uD83D\uDC8B\u200D)?\uD83E\uDDD1\uD83C[\uDFFC-\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF84\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83E\uDDD1\uD83C[\uDFFB-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFC(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D(?:\uD83D\uDC8B\u200D)?\uD83E\uDDD1\uD83C[\uDFFB\uDFFD-\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF84\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83E\uDDD1\uD83C[\uDFFB-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFD(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D(?:\uD83D\uDC8B\u200D)?\uD83E\uDDD1\uD83C[\uDFFB\uDFFC\uDFFE\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF84\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83E\uDDD1\uD83C[\uDFFB-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFE(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D(?:\uD83D\uDC8B\u200D)?\uD83E\uDDD1\uD83C[\uDFFB-\uDFFD\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF84\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83E\uDDD1\uD83C[\uDFFB-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFF(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D(?:\uD83D\uDC8B\u200D)?\uD83E\uDDD1\uD83C[\uDFFB-\uDFFE]|\uD83C[\uDF3E\uDF73\uDF7C\uDF84\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83E\uDDD1\uD83C[\uDFFB-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?))?|[\uDDD2\uDDD3](?:\uD83C[\uDFFB-\uDFFF])?|\uDDD4(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDDD5(?:\uD83C[\uDFFB-\uDFFF])?|[\uDDD6-\uDDDD](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDDDE\uDDDF](?:\u200D[\u2640\u2642]\uFE0F?)?|[\uDDE0-\uDDFF\uDE70-\uDE74\uDE78-\uDE7A\uDE80-\uDE86\uDE90-\uDEA8\uDEB0-\uDEB6\uDEC0-\uDEC2\uDED0-\uDED6])", "").Trim();
    }

    public static string RemoveStopWord(string MainString)
    {
        string[] stopWords = new string[] { "a", "about", "above", "after", "again", "against", "ain", "all", "am", "an", "and", "any", "are", "aren", "aren't", "as", "at", "be", "because", "been", "before", "being", "below", "between", "both", "but", "by", "can", "couldn", "couldn't", "d", "did", "didn", "didn't", "do", "does", "doesn", "doesn't", "doing", "don", "don't", "down", "during", "each", "few", "for", "from", "further", "had", "hadn", "hadn't", "has", "hasn", "hasn't", "have", "haven", "haven't", "having", "he", "her", "here", "hers", "herself", "him", "himself", "his", "how", "i", "if", "in", "into", "is", "isn", "isn't", "it", "it's", "its", "itself", "just", "ll", "m", "ma", "me", "mightn", "mightn't", "more", "most", "mustn", "mustn't", "my", "myself", "needn", "needn't", "no", "nor", "not", "now", "o", "of", "off", "on", "once", "only", "or", "other", "our", "ours", "ourselves", "out", "over", "own", "re", "s", "same", "shan", "shan't", "she", "she's", "should", "should've", "shouldn", "shouldn't", "so", "some", "such", "t", "than", "that", "that'll", "the", "their", "theirs", "them", "themselves", "then", "there", "these", "they", "this", "those", "through", "to", "too", "under", "until", "up", "ve", "very", "was", "wasn", "wasn't", "we", "were", "weren", "weren't", "what", "when", "where", "which", "while", "who", "whom", "why", "will", "with", "won", "won't", "wouldn", "wouldn't", "y", "you", "you'd", "you'll", "you're", "you've", "your", "yours", "yourself", "yourselves", "could", "he'd", "he'll", "he's", "here's", "how's", "i'd", "i'll", "i'm", "i've", "let's", "ought", "she'd", "she'll", "that's", "there's", "they'd", "they'll", "they're", "they've", "we'd", "we'll", "we're", "we've", "what's", "when's", "where's", "who's", "why's", "would" };
        string[] splitWords = MainString.Split(' ');

        foreach (string word in stopWords)
        {
            splitWords = splitWords.Where(e => e != word).ToArray();
        }
        return String.Join(" ", splitWords).Trim();
    }

    #endregion

    public static string GetLocalDateTime(string timezone, DateTime utcTime)
    {
        string locDate = "";
        if (!string.IsNullOrEmpty(timezone))
        {
            TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(timezone);
            DateTime cstTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, tz);
            locDate = cstTime.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
            tz = null;
        }
        else
        {
            locDate = utcTime.ToString("yyyy'-'MM'-'dd HH':'mm':'ss");
        }
        return locDate;
    }

    public static void CreateResponse<T>(string code, string status, string message, out Response actionResponse, T objResponse = null) where T : class
    {
        actionResponse = new Response()
        {
            code = code,
            status = status,
            message = message,
            data = objResponse
        };

    }

    public static bool IsTrademark(string inputString)
    {
        bool result = false;
        inputString = inputString.ToLower().Replace(" ", "");
        Regex rgx = new Regex("[^a-z0-9]");
        inputString = rgx.Replace(inputString, "");
        rgx = null;
        string[] arrTrademark = Resources.CommonResource.TrepupTrademarks.Split(',');

        foreach (string val in arrTrademark)
        {
            if (inputString.Contains(val))
            {
                result = true;
                break;
            }
        }
        return result;
    }

    public static string RemoveSpecialKeyboardCharacters(string inputText, bool keepWhiteSpace)
    {
        try
        {
            Regex regex = new Regex(@"[\*\""\[\]\-\\\/|:<>{}~!?`'#%^.,+_();@&$=]", RegexOptions.None);
            inputText = regex.Replace(inputText, "");
            if (keepWhiteSpace)
            {
                regex = new Regex("[ ]{2,}", RegexOptions.None);
                inputText = regex.Replace(inputText, " ");
            }
            else
            {
                inputText = inputText.Replace(" ", "");
            }
            regex = null;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return inputText.Trim();

    }

    public static bool CheckSpecialCharacterAtBeginning(string inputText)
    {
        bool result = false;
        try
        {
            if (!Char.IsLetterOrDigit(inputText[0]))
            {
                result = true;
            }
        }
        catch (Exception ex)
        {

        }
        return result;
    }

    public static bool CheckSymbolsNEmojis(string inputText)
    {
        bool result = false;
        try
        {
            Regex regex = new Regex(@"[#*0-9]\uFE0F?\u20E3|©\uFE0F?|℗\uFE0F?|[®\u203C\u2049\u2122\u2120\u2139\u2194-\u2199\u21A9\u21AA]\uFE0F?|[\u231A\u231B]|[\u2328\u23CF]\uFE0F?|[\u23E9-\u23EC]|[\u23ED-\u23EF]\uFE0F?|\u23F0|[\u23F1\u23F2]\uFE0F?|\u23F3|[\u23F8-\u23FA\u24C2\u25AA\u25AB\u25B6\u25C0\u25FB\u25FC]\uFE0F?|[\u25FD\u25FE]|[\u2600-\u2604\u260E\u2611]\uFE0F?|[\u2614\u2615]|\u2618\uFE0F?|\u261D(?:\uD83C[\uDFFB-\uDFFF]|\uFE0F)?|[\u2620\u2622\u2623\u2626\u262A\u262E\u262F\u2638-\u263A\u2640\u2642]\uFE0F?|[\u2648-\u2653]|[\u265F\u2660\u2663\u2665\u2666\u2668\u267B\u267E]\uFE0F?|\u267F|\u2692\uFE0F?|\u2693|[\u2694-\u2697\u2699\u269B\u269C\u26A0]\uFE0F?|\u26A1|\u26A7\uFE0F?|[\u26AA\u26AB]|[\u26B0\u26B1]\uFE0F?|[\u26BD\u26BE\u26C4\u26C5]|\u26C8\uFE0F?|\u26CE|[\u26CF\u26D1\u26D3]\uFE0F?|\u26D4|\u26E9\uFE0F?|\u26EA|[\u26F0\u26F1]\uFE0F?|[\u26F2\u26F3]|\u26F4\uFE0F?|\u26F5|[\u26F7\u26F8]\uFE0F?|\u26F9(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?|\uFE0F(?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\u26FA\u26FD]|\u2702\uFE0F?|\u2705|[\u2708\u2709]\uFE0F?|[\u270A\u270B](?:\uD83C[\uDFFB-\uDFFF])?|[\u270C\u270D](?:\uD83C[\uDFFB-\uDFFF]|\uFE0F)?|\u270F\uFE0F?|[\u2712\u2714\u2716\u271D\u2721]\uFE0F?|\u2728|[\u2733\u2734\u2744\u2747]\uFE0F?|[\u274C\u274E\u2753-\u2755\u2757]|\u2763\uFE0F?|\u2764(?:\u200D(?:\uD83D\uDD25|\uD83E\uDE79)|\uFE0F(?:\u200D(?:\uD83D\uDD25|\uD83E\uDE79))?)?|[\u2795-\u2797]|\u27A1\uFE0F?|[\u27B0\u27BF]|[\u2934\u2935\u2B05-\u2B07]\uFE0F?|[\u2B1B\u2B1C\u2B50\u2B55]|[\u3030\u303D\u3297\u3299]\uFE0F?|\uD83C(?:[\uDC04\uDCCF]|[\uDD70\uDD71\uDD7E\uDD7F]\uFE0F?|[\uDD8E\uDD91-\uDD9A]|\uDDE6\uD83C[\uDDE8-\uDDEC\uDDEE\uDDF1\uDDF2\uDDF4\uDDF6-\uDDFA\uDDFC\uDDFD\uDDFF]|\uDDE7\uD83C[\uDDE6\uDDE7\uDDE9-\uDDEF\uDDF1-\uDDF4\uDDF6-\uDDF9\uDDFB\uDDFC\uDDFE\uDDFF]|\uDDE8\uD83C[\uDDE6\uDDE8\uDDE9\uDDEB-\uDDEE\uDDF0-\uDDF5\uDDF7\uDDFA-\uDDFF]|\uDDE9\uD83C[\uDDEA\uDDEC\uDDEF\uDDF0\uDDF2\uDDF4\uDDFF]|\uDDEA\uD83C[\uDDE6\uDDE8\uDDEA\uDDEC\uDDED\uDDF7-\uDDFA]|\uDDEB\uD83C[\uDDEE-\uDDF0\uDDF2\uDDF4\uDDF7]|\uDDEC\uD83C[\uDDE6\uDDE7\uDDE9-\uDDEE\uDDF1-\uDDF3\uDDF5-\uDDFA\uDDFC\uDDFE]|\uDDED\uD83C[\uDDF0\uDDF2\uDDF3\uDDF7\uDDF9\uDDFA]|\uDDEE\uD83C[\uDDE8-\uDDEA\uDDF1-\uDDF4\uDDF6-\uDDF9]|\uDDEF\uD83C[\uDDEA\uDDF2\uDDF4\uDDF5]|\uDDF0\uD83C[\uDDEA\uDDEC-\uDDEE\uDDF2\uDDF3\uDDF5\uDDF7\uDDFC\uDDFE\uDDFF]|\uDDF1\uD83C[\uDDE6-\uDDE8\uDDEE\uDDF0\uDDF7-\uDDFB\uDDFE]|\uDDF2\uD83C[\uDDE6\uDDE8-\uDDED\uDDF0-\uDDFF]|\uDDF3\uD83C[\uDDE6\uDDE8\uDDEA-\uDDEC\uDDEE\uDDF1\uDDF4\uDDF5\uDDF7\uDDFA\uDDFF]|\uDDF4\uD83C\uDDF2|\uDDF5\uD83C[\uDDE6\uDDEA-\uDDED\uDDF0-\uDDF3\uDDF7-\uDDF9\uDDFC\uDDFE]|\uDDF6\uD83C\uDDE6|\uDDF7\uD83C[\uDDEA\uDDF4\uDDF8\uDDFA\uDDFC]|\uDDF8\uD83C[\uDDE6-\uDDEA\uDDEC-\uDDF4\uDDF7-\uDDF9\uDDFB\uDDFD-\uDDFF]|\uDDF9\uD83C[\uDDE6\uDDE8\uDDE9\uDDEB-\uDDED\uDDEF-\uDDF4\uDDF7\uDDF9\uDDFB\uDDFC\uDDFF]|\uDDFA\uD83C[\uDDE6\uDDEC\uDDF2\uDDF3\uDDF8\uDDFE\uDDFF]|\uDDFB\uD83C[\uDDE6\uDDE8\uDDEA\uDDEC\uDDEE\uDDF3\uDDFA]|\uDDFC\uD83C[\uDDEB\uDDF8]|\uDDFD\uD83C\uDDF0|\uDDFE\uD83C[\uDDEA\uDDF9]|\uDDFF\uD83C[\uDDE6\uDDF2\uDDFC]|\uDE01|\uDE02\uFE0F?|[\uDE1A\uDE2F\uDE32-\uDE36]|\uDE37\uFE0F?|[\uDE38-\uDE3A\uDE50\uDE51\uDF00-\uDF20]|[\uDF21\uDF24-\uDF2C]\uFE0F?|[\uDF2D-\uDF35]|\uDF36\uFE0F?|[\uDF37-\uDF7C]|\uDF7D\uFE0F?|[\uDF7E-\uDF84]|\uDF85(?:\uD83C[\uDFFB-\uDFFF])?|[\uDF86-\uDF93]|[\uDF96\uDF97\uDF99-\uDF9B\uDF9E\uDF9F]\uFE0F?|[\uDFA0-\uDFC1]|\uDFC2(?:\uD83C[\uDFFB-\uDFFF])?|[\uDFC3\uDFC4](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDFC5\uDFC6]|\uDFC7(?:\uD83C[\uDFFB-\uDFFF])?|[\uDFC8\uDFC9]|\uDFCA(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDFCB\uDFCC](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?|\uFE0F(?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDFCD\uDFCE]\uFE0F?|[\uDFCF-\uDFD3]|[\uDFD4-\uDFDF]\uFE0F?|[\uDFE0-\uDFF0]|\uDFF3(?:\u200D(?:\u26A7\uFE0F?|\uD83C\uDF08)|\uFE0F(?:\u200D(?:\u26A7\uFE0F?|\uD83C\uDF08))?)?|\uDFF4(?:\u200D\u2620\uFE0F?|\uDB40\uDC67\uDB40\uDC62\uDB40(?:\uDC65\uDB40\uDC6E\uDB40\uDC67|\uDC73\uDB40\uDC63\uDB40\uDC74|\uDC77\uDB40\uDC6C\uDB40\uDC73)\uDB40\uDC7F)?|[\uDFF5\uDFF7]\uFE0F?|[\uDFF8-\uDFFF])|\uD83D(?:[\uDC00-\uDC07]|\uDC08(?:\u200D\u2B1B)?|[\uDC09-\uDC14]|\uDC15(?:\u200D\uD83E\uDDBA)?|[\uDC16-\uDC3A]|\uDC3B(?:\u200D\u2744\uFE0F?)?|[\uDC3C-\uDC3E]|\uDC3F\uFE0F?|\uDC40|\uDC41(?:\u200D\uD83D\uDDE8\uFE0F?|\uFE0F(?:\u200D\uD83D\uDDE8\uFE0F?)?)?|[\uDC42\uDC43](?:\uD83C[\uDFFB-\uDFFF])?|[\uDC44\uDC45]|[\uDC46-\uDC50](?:\uD83C[\uDFFB-\uDFFF])?|[\uDC51-\uDC65]|[\uDC66\uDC67](?:\uD83C[\uDFFB-\uDFFF])?|\uDC68(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:\uDC8B\u200D\uD83D)?\uDC68|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D(?:\uDC66(?:\u200D\uD83D\uDC66)?|\uDC67(?:\u200D\uD83D[\uDC66\uDC67])?|[\uDC68\uDC69]\u200D\uD83D(?:\uDC66(?:\u200D\uD83D\uDC66)?|\uDC67(?:\u200D\uD83D[\uDC66\uDC67])?)|[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92])|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|\uD83C(?:\uDFFB(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:\uDC8B\u200D\uD83D)?\uDC68\uD83C[\uDFFB-\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D\uDC68\uD83C[\uDFFC-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFC(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:\uDC8B\u200D\uD83D)?\uDC68\uD83C[\uDFFB-\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D\uDC68\uD83C[\uDFFB\uDFFD-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFD(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:\uDC8B\u200D\uD83D)?\uDC68\uD83C[\uDFFB-\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D\uDC68\uD83C[\uDFFB\uDFFC\uDFFE\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFE(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:\uDC8B\u200D\uD83D)?\uDC68\uD83C[\uDFFB-\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D\uDC68\uD83C[\uDFFB-\uDFFD\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFF(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:\uDC8B\u200D\uD83D)?\uDC68\uD83C[\uDFFB-\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D\uDC68\uD83C[\uDFFB-\uDFFE]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?))?|\uDC69(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:\uDC8B\u200D\uD83D)?[\uDC68\uDC69]|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D(?:\uDC66(?:\u200D\uD83D\uDC66)?|\uDC67(?:\u200D\uD83D[\uDC66\uDC67])?|\uDC69\u200D\uD83D(?:\uDC66(?:\u200D\uD83D\uDC66)?|\uDC67(?:\u200D\uD83D[\uDC66\uDC67])?)|[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92])|\uD83E[\uDDAF-\uDDB3\uDDBC\uDDBD])|\uD83C(?:\uDFFB(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF]|\uDC8B\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF])|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFC-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFC(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF]|\uDC8B\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF])|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB\uDFFD-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFD(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF]|\uDC8B\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF])|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB\uDFFC\uDFFE\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFE(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF]|\uDC8B\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF])|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFD\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFF(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D\uD83D(?:[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF]|\uDC8B\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFF])|\uD83C[\uDF3E\uDF73\uDF7C\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83D[\uDC68\uDC69]\uD83C[\uDFFB-\uDFFE]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?))?|\uDC6A|[\uDC6B-\uDC6D](?:\uD83C[\uDFFB-\uDFFF])?|\uDC6E(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDC6F(?:\u200D[\u2640\u2642]\uFE0F?)?|[\uDC70\uDC71](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDC72(?:\uD83C[\uDFFB-\uDFFF])?|\uDC73(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDC74-\uDC76](?:\uD83C[\uDFFB-\uDFFF])?|\uDC77(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDC78(?:\uD83C[\uDFFB-\uDFFF])?|[\uDC79-\uDC7B]|\uDC7C(?:\uD83C[\uDFFB-\uDFFF])?|[\uDC7D-\uDC80]|[\uDC81\uDC82](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDC83(?:\uD83C[\uDFFB-\uDFFF])?|\uDC84|\uDC85(?:\uD83C[\uDFFB-\uDFFF])?|[\uDC86\uDC87](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDC88-\uDC8E]|\uDC8F(?:\uD83C[\uDFFB-\uDFFF])?|\uDC90|\uDC91(?:\uD83C[\uDFFB-\uDFFF])?|[\uDC92-\uDCA9]|\uDCAA(?:\uD83C[\uDFFB-\uDFFF])?|[\uDCAB-\uDCFC]|\uDCFD\uFE0F?|[\uDCFF-\uDD3D]|[\uDD49\uDD4A]\uFE0F?|[\uDD4B-\uDD4E\uDD50-\uDD67]|[\uDD6F\uDD70\uDD73]\uFE0F?|\uDD74(?:\uD83C[\uDFFB-\uDFFF]|\uFE0F)?|\uDD75(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?|\uFE0F(?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDD76-\uDD79]\uFE0F?|\uDD7A(?:\uD83C[\uDFFB-\uDFFF])?|[\uDD87\uDD8A-\uDD8D]\uFE0F?|\uDD90(?:\uD83C[\uDFFB-\uDFFF]|\uFE0F)?|[\uDD95\uDD96](?:\uD83C[\uDFFB-\uDFFF])?|\uDDA4|[\uDDA5\uDDA8\uDDB1\uDDB2\uDDBC\uDDC2-\uDDC4\uDDD1-\uDDD3\uDDDC-\uDDDE\uDDE1\uDDE3\uDDE8\uDDEF\uDDF3\uDDFA]\uFE0F?|[\uDDFB-\uDE2D]|\uDE2E(?:\u200D\uD83D\uDCA8)?|[\uDE2F-\uDE34]|\uDE35(?:\u200D\uD83D\uDCAB)?|\uDE36(?:\u200D\uD83C\uDF2B\uFE0F?)?|[\uDE37-\uDE44]|[\uDE45-\uDE47](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDE48-\uDE4A]|\uDE4B(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDE4C(?:\uD83C[\uDFFB-\uDFFF])?|[\uDE4D\uDE4E](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDE4F(?:\uD83C[\uDFFB-\uDFFF])?|[\uDE80-\uDEA2]|\uDEA3(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDEA4-\uDEB3]|[\uDEB4-\uDEB6](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDEB7-\uDEBF]|\uDEC0(?:\uD83C[\uDFFB-\uDFFF])?|[\uDEC1-\uDEC5]|\uDECB\uFE0F?|\uDECC(?:\uD83C[\uDFFB-\uDFFF])?|[\uDECD-\uDECF]\uFE0F?|[\uDED0-\uDED2\uDED5-\uDED7]|[\uDEE0-\uDEE5\uDEE9]\uFE0F?|[\uDEEB\uDEEC]|[\uDEF0\uDEF3]\uFE0F?|[\uDEF4-\uDEFC\uDFE0-\uDFEB])|\uD83E(?:\uDD0C(?:\uD83C[\uDFFB-\uDFFF])?|[\uDD0D\uDD0E]|\uDD0F(?:\uD83C[\uDFFB-\uDFFF])?|[\uDD10-\uDD17]|[\uDD18-\uDD1C](?:\uD83C[\uDFFB-\uDFFF])?|\uDD1D|[\uDD1E\uDD1F](?:\uD83C[\uDFFB-\uDFFF])?|[\uDD20-\uDD25]|\uDD26(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDD27-\uDD2F]|[\uDD30-\uDD34](?:\uD83C[\uDFFB-\uDFFF])?|\uDD35(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDD36(?:\uD83C[\uDFFB-\uDFFF])?|[\uDD37-\uDD39](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDD3A|\uDD3C(?:\u200D[\u2640\u2642]\uFE0F?)?|[\uDD3D\uDD3E](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDD3F-\uDD45\uDD47-\uDD76]|\uDD77(?:\uD83C[\uDFFB-\uDFFF])?|[\uDD78\uDD7A-\uDDB4]|[\uDDB5\uDDB6](?:\uD83C[\uDFFB-\uDFFF])?|\uDDB7|[\uDDB8\uDDB9](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDDBA|\uDDBB(?:\uD83C[\uDFFB-\uDFFF])?|[\uDDBC-\uDDCB]|[\uDDCD-\uDDCF](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDDD0|\uDDD1(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\uD83C[\uDF3E\uDF73\uDF7C\uDF84\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83E\uDDD1|[\uDDAF-\uDDB3\uDDBC\uDDBD]))|\uD83C(?:\uDFFB(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D(?:\uD83D\uDC8B\u200D)?\uD83E\uDDD1\uD83C[\uDFFC-\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF84\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83E\uDDD1\uD83C[\uDFFB-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFC(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D(?:\uD83D\uDC8B\u200D)?\uD83E\uDDD1\uD83C[\uDFFB\uDFFD-\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF84\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83E\uDDD1\uD83C[\uDFFB-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFD(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D(?:\uD83D\uDC8B\u200D)?\uD83E\uDDD1\uD83C[\uDFFB\uDFFC\uDFFE\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF84\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83E\uDDD1\uD83C[\uDFFB-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFE(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D(?:\uD83D\uDC8B\u200D)?\uD83E\uDDD1\uD83C[\uDFFB-\uDFFD\uDFFF]|\uD83C[\uDF3E\uDF73\uDF7C\uDF84\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83E\uDDD1\uD83C[\uDFFB-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?|\uDFFF(?:\u200D(?:[\u2695\u2696\u2708]\uFE0F?|\u2764\uFE0F?\u200D(?:\uD83D\uDC8B\u200D)?\uD83E\uDDD1\uD83C[\uDFFB-\uDFFE]|\uD83C[\uDF3E\uDF73\uDF7C\uDF84\uDF93\uDFA4\uDFA8\uDFEB\uDFED]|\uD83D[\uDCBB\uDCBC\uDD27\uDD2C\uDE80\uDE92]|\uD83E(?:\uDD1D\u200D\uD83E\uDDD1\uD83C[\uDFFB-\uDFFF]|[\uDDAF-\uDDB3\uDDBC\uDDBD])))?))?|[\uDDD2\uDDD3](?:\uD83C[\uDFFB-\uDFFF])?|\uDDD4(?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|\uDDD5(?:\uD83C[\uDFFB-\uDFFF])?|[\uDDD6-\uDDDD](?:\u200D[\u2640\u2642]\uFE0F?|\uD83C[\uDFFB-\uDFFF](?:\u200D[\u2640\u2642]\uFE0F?)?)?|[\uDDDE\uDDDF](?:\u200D[\u2640\u2642]\uFE0F?)?|[\uDDE0-\uDDFF\uDE70-\uDE74\uDE78-\uDE7A\uDE80-\uDE86\uDE90-\uDEA8\uDEB0-\uDEB6\uDEC0-\uDEC2\uDED0-\uDED6])", RegexOptions.None);
            if (regex.IsMatch(inputText))
            {
                result = true;
            }

            regex = null;
        }
        catch (Exception ex)
        {

        }
        return result;
    }

    public static bool CheckAlphanumericNDot(string inputText)
    {
        bool result = false;
        try
        {
            Regex regex = new Regex("[^a-zA-Z0-9.]", RegexOptions.None);
            if (regex.IsMatch(inputText))
            {
                result = true;
            }

            regex = null;
        }
        catch (Exception ex)
        {
        }
        return result;
    }

    public static bool CheckAlphabets(string inputText)
    {
        bool result = false;
        try
        {
            Regex regex = new Regex(@"\w*[a-z]\w*", RegexOptions.None);
            if (regex.IsMatch(inputText.ToLower()))
            {
                result = true;
            }

            regex = null;
        }
        catch (Exception ex)
        {
        }
        return result;
    }

    public static bool TLDValidation(string rawString)
    {
        try
        {
            bool status = false;

            if (rawString.IndexOf('.') > 0)
            {
                string[] arrayString = rawString.Split('.');
                string domain = arrayString[arrayString.Length - 1].ToLower();
                string[] TLDArray = TLDs.Split('|');

                for (int i = 0; i < TLDArray.Length; i++)
                {
                    if (TLDArray[i].ToLower().Equals(domain))
                    {
                        status = true;
                        break;
                    }
                }
            }
            return status;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

  
    public static T GetDynamicObjValue<T>(string propertyName, dynamic dynamicObj)
    {
        T result = default(T);

        try
        {
            string[] arrayProperty = propertyName.Split('.');
            foreach (string item in arrayProperty)
            {
                var propertyInfo = dynamicObj.GetType().GetProperty(item);
                if (propertyInfo != null)
                {
                    dynamicObj = propertyInfo.GetValue(dynamicObj, null);
                }
            }

            result = dynamicObj;
        }
        catch (Exception) { }

        return result;
    }

    public static bool ValidateRestrictedNames(string name)
    {
        bool result = false;
        DataSet dsResult = new DataSet();
        try
        {
            string spName = Resources.SPResource.IsRestrictedName;
            if (!string.IsNullOrEmpty(name))
            {
                name = Regex.Replace(name.ToLower().Trim().Replace(".", "").Replace(" ", ""), "[^0-9a-zA-Z\\.]+", "");

                if (!string.IsNullOrEmpty(name))
                {
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@SearchString", name) { SqlDbType = SqlDbType.NVarChar };

                    dsResult = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString(), CommandType.StoredProcedure, spName, parameters);
                    if (Common.IsValidDataSet(dsResult))
                    {
                        result = true;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return result;
    }

    public static bool IsMaxWords(string inputString, int minWords)
    {
        bool result = false;
        if (inputString.Split(' ').Length > minWords)
        {
            result = true;
        }
        return result;
    }

    public static bool IsSepcialCharacters(string inputString)
    {
        bool result = false;
        Regex regSpecialChar = new Regex(@"[\*\""\[\]\-\\\/|:<>{}~!?`#%^,+_();@&$=0-9]", RegexOptions.IgnoreCase);
        if (regSpecialChar.IsMatch(inputString))
        {
            result = true;
        }
        return result;
    }

    public static bool IsBeginingEndChar(string inputString, char[] arrayChar)
    {
        bool result = false;
        foreach (var item in arrayChar)
        {
            if (!result)
            {
                if (inputString.IndexOf(item) == 0 || inputString.IndexOf(item) == inputString.Length - 1)
                {
                    result = true;
                }
            }
            else
            {
                break;
            }
        }
        return result;
    }

    public static bool IsBeginingChar(string inputString, char[] arrayChar)
    {
        bool result = false;
        foreach (var item in arrayChar)
        {
            if (!result)
            {
                if (inputString.IndexOf(item) == 0)
                {
                    result = true;
                }
            }
            else
            {
                break;
            }
        }
        return result;
    }

    public static bool IsMaxFullStops(string inputString, int minFullStops)
    {
        bool result = false;
        if (inputString.Split('.').Length - 1 > minFullStops)
        {
            result = true;
        }
        return result;
    }

    public static bool IsConsecutiveChar(string inputString, char[] arrayChar)
    {
        bool result = false;
        foreach (var item in arrayChar)
        {
            Regex regDotSequence = new Regex(@"[" + item + "]{2,}", RegexOptions.IgnoreCase);

            if (!result)
            {
                if (regDotSequence.IsMatch(inputString))
                {
                    result = true;
                }
            }
            else
            {
                break;
            }
        }
        return result;
    }

    public static bool IsMaxChar(string inputString, char charCheck, int minChars)
    {
        bool result = false;
        if (inputString.Split(charCheck).Length - 1 > minChars)
        {
            result = true;
        }
        return result;
    }

    public static bool IsFullStopWithoutSpace(string inputString)
    {
        bool result = false;
        Regex regDotSpaceSequence = new Regex(@"\.([^\s])", RegexOptions.IgnoreCase);
        if (regDotSpaceSequence.IsMatch(inputString))
        {
            result = true;
        }
        return result;
    }

    public static bool IsContainWords(string inputString, string[] arrayStr)
    {
        bool result = false;

        foreach (var item in arrayStr)
        {
            if (!result)
            {
                if (inputString.ToLower().IndexOf(item) > -1)
                {
                    result = true;
                }
            }
            else
            {
                break;
            }
        }
        return result;
    }

    public static bool UsernameGeoLocationCheck(string name)
    {
        bool result = false;
        DataSet dsResult = new DataSet();
        try
        {
            string spName = Resources.SPResource.StoreNameGeoLocationCheck;
            if (!string.IsNullOrEmpty(name))
            {
                name = Regex.Replace(name.ToLower().Trim().Replace(".", "").Replace(" ", ""), "[^0-9a-zA-Z\\.]+", "");

                if (!string.IsNullOrEmpty(name))
                {
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@SearchString", name) { SqlDbType = SqlDbType.NVarChar };

                    dsResult = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString(), CommandType.StoredProcedure, spName, parameters);
                    if (Common.IsValidDataSet(dsResult))
                    {
                        result = true;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return result;
    }

    public static string ShowStringWithComma(double value, bool Type, bool isdecimal)
    {
        if (Type == true)
        {
            if (!isdecimal)
            {
                return value.ToString("n0", CultureInfo.GetCultureInfo("hi-IN"));
            }
            else
            {
                if (Convert.ToDouble(value) < 0.01)
                {
                    return "0.01";
                }
                else
                {
                    return value.ToString("n", CultureInfo.GetCultureInfo("hi-IN"));
                }
            }
        }
        else
        {
            if (!isdecimal)
            {
                Int64 Vailue1 = Convert.ToInt64(value);
                return Vailue1.ToString("n0", CultureInfo.GetCultureInfo("en-US"));
            }
            else
            {
                if (Convert.ToDouble(value) < 0.01)
                {
                    return "0.01";
                }
                else
                {
                    return value.ToString("n", CultureInfo.GetCultureInfo("en-US"));
                }

            }
        }
    }

    public static string spaceInNumberWith4Digits(string s)
    {
        string response = string.Empty;
        if (!string.IsNullOrEmpty(s))
        {
            string regex = string.Empty;
            regex = string.Format(".{{1,{0}}}", 4);
            response = Regex.Replace(s, regex, "$& ").TrimEnd(' ');
        }
        return response;
    }

}