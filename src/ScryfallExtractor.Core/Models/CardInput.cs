using System.Text.Json.Serialization;
using ScryfallExtractor.Core.Converters;

namespace ScryfallExtractor.Core.Models {
    public enum CardLegality {
        NotLegal = 1,
        Legal = 2,
        Restricted = 3,
        Banned = 4
    }

    public sealed class CardInput {
        // object
        [JsonPropertyName("object")]
        public string Object { get; set; }
        // id
        [JsonPropertyName("id")]
        public string Id { get; set; }
        // oracle_id
        [JsonPropertyName("oracle_id")]
        public string OracleId { get; set; }
        // multiverse_ids
        [JsonPropertyName("multiverse_ids")]
        public IList<int> MultiverseIds { get; set; }
        // mtgo_id
        [JsonPropertyName("mtgo_id")]
        public int MtgoId { get; set; }
        // tcgplayer_id
        [JsonPropertyName("tcgplayer_id")]
        public int TcgPlayerId { get; set; }
        // cardmarket_id
        [JsonPropertyName("cardmarket_id")]
        public int CardMarketId { get; set; }
        // name
        [JsonPropertyName("name")]
        public string Name { get; set; }
        // lang
        [JsonPropertyName("language")]
        public string Language { get; set; }
        // released_at
        [JsonPropertyName("released_at")]
        public DateTime ReleasedAt { get; set; }
        // uri
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
        // scryfall_uri
        [JsonPropertyName("scryfall_uri")]
        public string ScryfallUri { get; set; }
        // layout
        [JsonPropertyName("layout")]
        public string Layout { get; set; }
        // highres_image
        [JsonPropertyName("highres_image")]
        public bool HasHighResImage { get; set; }
        // image_status
        [JsonPropertyName("image_status")]
        public string ImageStatus { get; set; }
        // image_uris
        [JsonPropertyName("image_uris")]
        public ImageUriInput ImageUris { get; set; }
        // mana_cost
        [JsonPropertyName("mana_cost")]
        public string ManaCost { get; set; }
        // cmc
        [JsonPropertyName("cmc")]
        public float Cmc { get; set; }
        // type_line
        [JsonPropertyName("type_line")]
        public string TypeLine { get; set; }
        // oracle_text
        [JsonPropertyName("oracle_text")]
        public string OracleText { get; set; }
        // colors
        [JsonPropertyName("colors")]
        public IList<string> Colors { get; set; }
        // color_identity
        [JsonPropertyName("color_identity"), JsonConverter(typeof(ColorPieTextToEnumConverter))]
        public ColorPie ColorIdentity { get; set; }
        // keywords
        [JsonPropertyName("keywords")]
        public IList<string> Keywords { get; set; }
        // legalities
        [JsonPropertyName("legalities")]
        public LegalitiesInput Legalities { get; set; }
        // games
        [JsonPropertyName("games")]
        public IList<string> Games { get; set; }
        // reserved
        [JsonPropertyName("reserved")]
        public bool IsReserved { get; set; }
        // foil
        [JsonPropertyName("foil")]
        public bool IsFoil { get; set; }
        // nonfoil
        [JsonPropertyName("nonfoil")]
        public bool IsNonFoil { get; set; }
        // finishes
        [JsonPropertyName("finishes")]
        public IList<string> Finishes { get; set; }
        // oversized
        [JsonPropertyName("oversized")]
        public bool IsOversized { get; set; }
        // promo
        [JsonPropertyName("promo")]
        public bool IsPromo { get; set; }
        // reprint
        [JsonPropertyName("reprint")]
        public bool IsReprint { get; set; }
        // variation
        [JsonPropertyName("variation")]
        public bool IsVariation { get; set; }
        // set_id
        [JsonPropertyName("set_id")]
        public string SetId { get; set; }
        // set
        [JsonPropertyName("set")]
        public string Set { get; set; }
        // set_name
        [JsonPropertyName("set_name")]
        public string SetName { get; set; }
        // set_type
        [JsonPropertyName("set_type")]
        public string SetType { get; set; }
        // set_uri
        [JsonPropertyName("set_uri")]
        public string SetUri { get; set; }
        // set_search_uri
        [JsonPropertyName("set_search_uri")]
        public string SetSearchUri { get; set; }
        // scryfall_set_uri
        [JsonPropertyName("scryfall_set_uri")]
        public string ScryfallSetUri { get; set; }
        // rulings_uri
        [JsonPropertyName("rulings_uri")]
        public string RulingsUri { get; set; }
        // prints_search_uri
        [JsonPropertyName("prints_search_uri")]
        public string PrintsSearchUri { get; set; }
        // collector_number
        [JsonPropertyName("collector_number")]
        public string CollectorNumber { get; set; }
        // digital
        [JsonPropertyName("digital")]
        public bool IsDigital { get; set; }
        // rarity
        [JsonPropertyName("rarity"), JsonConverter(typeof(CardRarityTextToEnumConverter))]
        public CardRarity Rarity { get; set; }
        // card_back_id
        [JsonPropertyName("card_back_id")]
        public string CardBackId { get; set; }
        // artist
        [JsonPropertyName("artist")]
        public string Artist { get; set; }
        // artist_ids
        [JsonPropertyName("artist_ids")]
        public IList<string> ArtistIds { get; set; }
        // illustration_id
        [JsonPropertyName("illustration_id")]
        public string IllustrationId { get; set; }
        // border_color
        [JsonPropertyName("border_color")]
        public string BorderColor { get; set; }
        // frame
        [JsonPropertyName("frame")]
        public string Frame { get; set; }
        // security_stamp
        [JsonPropertyName("security_stamp")]
        public string SecurityStamp { get; set; }
        // full_art
        [JsonPropertyName("full_art")]
        public bool IsFullArt { get; set; }
        // textless
        [JsonPropertyName("textless")]
        public bool IsTextless { get; set; }
        // booster
        [JsonPropertyName("booster")]
        public bool IsBooster { get; set; }
        // story_spotlight
        [JsonPropertyName("story_spotlight")]
        public bool IsStorySpotlight { get; set; }
        // edhrec_rank
        [JsonPropertyName("edhrec_rank")]
        public int EdhRecRank { get; set; }
        // penny_rank
        [JsonPropertyName("penny_rank")]
        public int PennyRank { get; set; }
        // prices
        [JsonPropertyName("prices")]
        public PricesInput Prices { get; set; }
        // related_uris
        [JsonPropertyName("related_uris")]
        public RelatedUriInput RelatedUris { get; set; }
        // purchase_uris
        [JsonPropertyName("purchase_uris")]
        public PurchaseUriInput PurchaseUris { get; set; }

        public class PurchaseUriInput {
            // tcgplayer
            [JsonPropertyName("tcgplayer")]
            public string TcgPlayer { get; set; }
            // cardmarket
            [JsonPropertyName("cardmarket")]
            public string CardMarket { get; set; } 
            // cardhoarder
            [JsonPropertyName("cardhoarder")]
            public string CardHoarder { get; set; }
        }
        public class RelatedUriInput {
            // gatherer
            [JsonPropertyName("gatherer")]
            public string Gatherer { get; set; }
            // tcgplayer_infinite_articles
            [JsonPropertyName("tcgplayer_infinite_articles")]
            public string TcgPlayerInfiniteArticles { get; set; }
            // tcgplayer_infinite_decks
            [JsonPropertyName("tcgplayer_infinite_decks")]
            public string TcgPlayerInfiniteDecks { get; set; }
            // edhrec
            [JsonPropertyName("edhrec")]
            public string EdhRec { get; set; }
        }
        public class PricesInput {
            // usd
            [JsonPropertyName("usd")]
            public string? Usd { get; set; }
            // usd_foil
            [JsonPropertyName("usd_foil")]
            public string? UsdFoil { get; set; }
            // usd_etched
            [JsonPropertyName("usd_etched")]
            public string? UsdEtched { get; set; }
            // eur
            [JsonPropertyName("eur")]
            public string? Eur { get; set; }
            // eur_foil
            [JsonPropertyName("eur_foil")]
            public string? EurFoil { get; set; }
            // tix
            [JsonPropertyName("tix")]
            public string? Tix { get; set; }
        }
        public class LegalitiesInput {
            // standard
            [JsonPropertyName("standard"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Standard { get; set; }
            // future
            [JsonPropertyName("future"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Future { get; set; }
            // historic
            [JsonPropertyName("historic"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Historic { get; set; }
            // timeless
            [JsonPropertyName("timeless"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Timeless { get; set; }
            // gladiator
            [JsonPropertyName("gladiator"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Gladiator { get; set; }
            // pioneer
            [JsonPropertyName("pioneer"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Pioneer { get; set; }
            // explorer
            [JsonPropertyName("explorer"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Explorer { get; set; }
            // modern
            [JsonPropertyName("modern"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Modern { get; set; }
            // legacy
            [JsonPropertyName("legacy"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Legacy { get; set; }
            // pauper
            [JsonPropertyName("pauper"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Pauper { get; set; }
            // vintage
            [JsonPropertyName("vintage"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Vintage { get; set; }
            // penny
            [JsonPropertyName("penny"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Penny { get; set; }
            // commander
            [JsonPropertyName("commander"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Commander { get; set; }
            // oathbreaker
            [JsonPropertyName("oathbreaker"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Oathbreaker { get; set; }
            // brawl
            [JsonPropertyName("brawl"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Brawl { get; set; }
            // historicbrawl
            [JsonPropertyName("historicbrawl"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality HistoricBrawl { get; set; }
            // alchemy
            [JsonPropertyName("alchemy"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Alchemy { get; set; }
            //paupercommander
            [JsonPropertyName("paupercommander"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality PauperCommander { get; set; }
            // duel
            [JsonPropertyName("duel"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality Duel { get; set; }
            // oldschool
            [JsonPropertyName("oldschool"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality OldSchool { get; set; }
            // premodern
            [JsonPropertyName("premodern"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality PreModern { get; set; }
            // predh
            [JsonPropertyName("predh"), JsonConverter(typeof(CardLegalityTextToEnumConverter))]
            public CardLegality PrEdh { get; set; }
        }
        public class ImageUriInput {
            // small
            [JsonPropertyName("small")]
            public string Small { get; set; }
            // normal
            [JsonPropertyName("normal")]
            public string Normal { get; set; }
            // large
            [JsonPropertyName("large")]
            public string Large { get; set; }
            // png
            [JsonPropertyName("png")]
            public string Png { get; set; }
            // art_crop
            [JsonPropertyName("art_crop")]
            public string ArtCrop { get; set; }
            // border_crop
            [JsonPropertyName("border_crop")]
            public string BorderCrop { get; set; }
        }
    }
}
