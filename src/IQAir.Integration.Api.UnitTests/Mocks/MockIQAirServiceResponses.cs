namespace IQAir.Integration.Api.UnitTests.Mocks;

public static class MockIQAirServiceResponses
{
    //Community
    public static string GetSupportedCountriesGoodResponse =>
        @"{""status"":""success"",""data"":[{""country"":""Afghanistan""},{""country"":""Albania""},{""country"":""Algeria""},{""country"":""Andorra""},{""country"":""Antarctica""},{""country"":""Argentina""},{""country"":""Armenia""},{""country"":""Australia""},{""country"":""Austria""},{""country"":""Azerbaijan""},{""country"":""Bahamas""},{""country"":""Bahrain""},{""country"":""Bangladesh""},{""country"":""Barbados""},{""country"":""Belarus""}]}";
    
    public static string GetStatesGoodResponse =>
        @"{""status"":""success"",""data"":[{""state"":""Andaman and Nicobar Islands""},{""state"":""Andhra Pradesh""},{""state"":""Assam""},{""state"":""Bihar""},{""state"":""Chandigarh""},{""state"":""Chhattisgarh""}]}";
    
    public static string GetCitiesGoodResponse =>
        @"{""status"":""success"",""data"":[{""city"":""Defence Colony""},{""city"":""Delhi""},{""city"":""Deoli""},{""city"":""New Delhi""},{""city"":""Shahdara""}]}";
    
    public static string GetNearestCityDateByIpResponse =>
        @"{""status"":""success"",""data"":{""city"":""New Delhi"",""state"":""Delhi"",""country"":""India"",""location"":{""type"":""Point"",""coordinates"":[77.231,28.656]},""current"":{""pollution"":{""ts"":""2025-12-23T09:00:00.000Z"",""aqius"":281,""mainus"":""p2"",""aqicn"":256,""maincn"":""p2""},""weather"":{""ts"":""2025-12-23T09:00:00.000Z"",""ic"":""50d"",""hu"":56,""pr"":1013,""tp"":21,""wd"":270,""ws"":3.6,""heatIndex"":21}}}}";
    
    public static string GetNearestCityDateByGpsResponse =>
        @"{""status"":""success"",""data"":{""city"":""New Delhi"",""state"":""Delhi"",""country"":""India"",""location"":{""type"":""Point"",""coordinates"":[77.231,28.656]},""current"":{""pollution"":{""ts"":""2025-12-23T09:00:00.000Z"",""aqius"":281,""mainus"":""p2"",""aqicn"":256,""maincn"":""p2""},""weather"":{""ts"":""2025-12-23T09:00:00.000Z"",""ic"":""50d"",""hu"":56,""pr"":1013,""tp"":21,""wd"":270,""ws"":3.6,""heatIndex"":21}}}}";
    
    public static string GetCityDateResponse =>
        @"{""status"":""success"",""data"":{""city"":""New Delhi"",""state"":""Delhi"",""country"":""India"",""location"":{""type"":""Point"",""coordinates"":[77.231,28.656]},""current"":{""pollution"":{""ts"":""2025-12-23T09:00:00.000Z"",""aqius"":281,""mainus"":""p2"",""aqicn"":256,""maincn"":""p2""},""weather"":{""ts"":""2025-12-23T09:00:00.000Z"",""ic"":""50d"",""hu"":56,""pr"":1013,""tp"":21,""wd"":270,""ws"":3.6,""heatIndex"":21}}}}";
    
    //Startap group api
    public static string GetStationsDateResponse =>
        @"{""status"": ""success"",""data"": [{""location"": {""type"": ""Point"",""coordinates"": [116.466258,39.954352]},""station"": ""US Embassy in Beijing""},{""location"": {""type"": ""Point"",""coordinates"": [116.2148532181,40.0078007235]},""station"": ""Botanical Garden""}]}";
    
    public static string GetSpecificationCityDataDateResponse =>
        @"{
  ""status"": ""success"",
  ""data"": {
    ""name"": ""Seocho-gu"",
    ""city"": ""Seoul"",
    ""state"": ""Seoul"",
    ""country"": ""South Korea"",
    ""location"": {
      ""type"": ""Point"",
      ""coordinates"": [
        126.994611,
        37.504547
      ]
    },
    ""units"": {
      ""p2"": ""ugm3"",
      ""p1"": ""ugm3"",
      ""o3"": ""ugm3"",
      ""n2"": ""ugm3"",
      ""s2"": ""ugm3"",
      ""co"": ""ugm3"",
      ""pm25"": ""ugm3"",
      ""pm10"": ""ugm3""
    },
    ""current"": {
      ""pollution"": {
        ""ts"": ""2025-09-08T08:00:00.000Z"",
        ""aqius"": 66,
        ""mainus"": ""o3"",
        ""aqicn"": 58,
        ""maincn"": ""o3"",
        ""p2"": {
          ""conc"": 12,
          ""aqius"": 56,
          ""aqicn"": 17
        },
        ""p1"": {
          ""conc"": 32,
          ""aqius"": 30,
          ""aqicn"": 32
        },
        ""o3"": {
          ""conc"": 166,
          ""aqius"": 66,
          ""aqicn"": 58
        },
        ""n2"": {
          ""conc"": 40,
          ""aqius"": 20,
          ""aqicn"": 20
        },
        ""s2"": {
          ""conc"": 7.6,
          ""aqius"": 3,
          ""aqicn"": 8
        },
        ""co"": {
          ""conc"": 561.1,
          ""aqius"": 5,
          ""aqicn"": 6
        }
      },
      ""weather"": {
        ""ts"": ""2025-09-08T08:00:00.000Z"",
        ""ic"": ""04d"",
        ""hu"": 61,
        ""pr"": 1010,
        ""tp"": 26,
        ""wd"": 275,
        ""ws"": 3.68,
        ""heatIndex"": 26
      }
    }
  }
}";

    public static string GetNearestStationDateResponse =>
        @"{
  ""status"": ""success"",
  ""data"": {
    ""city"": ""Beijing"",
    ""state"": ""Beijing"",
    ""country"": ""China"",
    ""location"": {
      ""type"": ""Point"",
      ""coordinates"": [
        116.462153,
        39.941674
      ]
    },
    ""current"": {
      ""pollution"": {
        ""ts"": ""2025-09-08T08:00:00.000Z"",
        ""aqius"": 57,
        ""mainus"": ""o3"",
        ""aqicn"": 44,
        ""maincn"": ""o3"",
        ""p2"": {
          ""conc"": 9,
          ""aqius"": 50,
          ""aqicn"": 13
        },
        ""p1"": {
          ""conc"": 28,
          ""aqius"": 26,
          ""aqicn"": 28
        },
        ""o3"": {
          ""conc"": 140,
          ""aqius"": 57,
          ""aqicn"": 44
        },
        ""n2"": {
          ""conc"": 10,
          ""aqius"": 5,
          ""aqicn"": 5
        },
        ""s2"": {
          ""conc"": 3,
          ""aqius"": 1,
          ""aqicn"": 3
        },
        ""co"": {
          ""conc"": 300,
          ""aqius"": 3,
          ""aqicn"": 3
        }
      },
      ""weather"": {
        ""ts"": ""2025-09-08T08:00:00.000Z"",
        ""ic"": ""01d"",
        ""hu"": 30,
        ""pr"": 1008,
        ""tp"": 31,
        ""wd"": 178,
        ""ws"": 4.54,
        ""heatIndex"": 30
      }
    },
    ""units"": {
      ""p2"": ""ugm3"",
      ""p1"": ""ugm3"",
      ""o3"": ""ugm3"",
      ""n2"": ""ugm3"",
      ""s2"": ""ugm3"",
      ""co"": ""ugm3"",
      ""pm25"": ""ugm3"",
      ""pm10"": ""ugm3""
    }
  }
}";
   
    //Enterprice
    public static string GetGlobalCityRankingResponse =>
      @"{
  ""status"": ""success"",
  ""data"": [
    {
      ""city"": ""Portland"",
      ""state"": ""Oregon"",
      ""country"": ""USA"",
      ""ranking"": {
        ""current_aqi"": 183,
        ""current_aqi_cn"": 154
      }
    },
    {
      ""city"": ""Eugene"",
      ""state"": ""Oregon"",
      ""country"": ""USA"",
      ""ranking"": {
        ""current_aqi"": 151,
        ""current_aqi_cn"": 77
      }
    },
    {
      ""city"": ""Dhaka"",
      ""state"": ""Dhaka"",
      ""country"": ""Bangladesh"",
      ""ranking"": {
        ""current_aqi"": 141,
        ""current_aqi_cn"": 71
      }
    },
    {
      ""city"": ""Mumbai"",
      ""state"": ""Maharashtra"",
      ""country"": ""India"",
      ""ranking"": {
        ""current_aqi"": 129,
        ""current_aqi_cn"": 65
      }
    },
    {
      ""city"": ""Jakarta"",
      ""state"": ""Jakarta"",
      ""country"": ""Indonesia"",
      ""ranking"": {
        ""current_aqi"": 121,
        ""current_aqi_cn"": 61
      }
    },
    {
      ""city"": ""Brasov"",
      ""state"": ""Centru"",
      ""country"": ""Romania"",
      ""ranking"": {
        ""current_aqi"": 118,
        ""current_aqi_cn"": 59,
        ""last_aqi"": 140,
        ""last_aqi_cn"": 71
      }
    },
    {
      ""city"": ""Chiang Mai"",
      ""state"": ""Chiang Mai"",
      ""country"": ""Thailand"",
      ""ranking"": {
        ""current_aqi"": 114,
        ""current_aqi_cn"": 58
      }
    },
    {
      ""city"": ""Santiago"",
      ""state"": ""Santiago Metropolitan"",
      ""country"": ""Chile"",
      ""ranking"": {
        ""current_aqi"": 109,
        ""current_aqi_cn"": 55
      }
    },
    {
      ""city"": ""Taipei"",
      ""state"": ""Taipei"",
      ""country"": ""Taiwan"",
      ""ranking"": {
        ""current_aqi"": 100,
        ""current_aqi_cn"": 50
      }
    },
    {
      ""city"": ""Kolkata"",
      ""state"": ""West Bengal"",
      ""country"": ""India"",
      ""ranking"": {
        ""current_aqi"": 98,
        ""current_aqi_cn"": 49
      }
    },
    {
      ""city"": ""Seattle"",
      ""state"": ""Washington"",
      ""country"": ""USA"",
      ""ranking"": {
        ""current_aqi"": 94,
        ""current_aqi_cn"": 46
      }
    },
    {
      ""city"": ""Beijing"",
      ""state"": ""Beijing"",
      ""country"": ""China"",
      ""ranking"": {
        ""current_aqi"": 90,
        ""current_aqi_cn"": 44
      }
    },
    {
      ""city"": ""Sao Paulo"",
      ""state"": ""Sao Paulo"",
      ""country"": ""Brazil"",
      ""ranking"": {
        ""current_aqi"": 89,
        ""current_aqi_cn"": 43
      }
    },
    {
      ""city"": ""Lahore"",
      ""state"": ""Punjab"",
      ""country"": ""Pakistan"",
      ""ranking"": {
        ""current_aqi"": 88,
        ""current_aqi_cn"": 43
      }
    },
    {
      ""city"": ""Osaka"",
      ""state"": ""Osaka"",
      ""country"": ""Japan"",
      ""ranking"": {
        ""current_aqi"": 84,
        ""current_aqi_cn"": 40
      }
    },
    {
      ""city"": ""Guangzhou"",
      ""state"": ""Guangdong"",
      ""country"": ""China"",
      ""ranking"": {
        ""current_aqi"": 83,
        ""current_aqi_cn"": 39
      }
    },
    {
      ""city"": ""Port Harcourt"",
      ""state"": ""Rivers"",
      ""country"": ""Nigeria"",
      ""ranking"": {
        ""current_aqi"": 83,
        ""current_aqi_cn"": 39,
        ""last_aqi"": 96,
        ""last_aqi_cn"": 48
      }
    },
    {
      ""city"": ""Hanoi"",
      ""state"": ""Hanoi"",
      ""country"": ""Vietnam"",
      ""ranking"": {
        ""current_aqi"": 80,
        ""current_aqi_cn"": 37
      }
    },
    {
      ""city"": ""Lima"",
      ""state"": ""Lima"",
      ""country"": ""Peru"",
      ""ranking"": {
        ""current_aqi"": 80,
        ""current_aqi_cn"": 37
      }
    },
    {
      ""city"": ""Chengdu"",
      ""state"": ""Sichuan"",
      ""country"": ""China"",
      ""ranking"": {
        ""current_aqi"": 79,
        ""current_aqi_cn"": 36
      }
    },
    {
      ""city"": ""Bogota"",
      ""state"": ""Bogota"",
      ""country"": ""Colombia"",
      ""ranking"": {
        ""current_aqi"": 76,
        ""current_aqi_cn"": 34
      }
    },
    {
      ""city"": ""Seoul"",
      ""state"": ""Seoul"",
      ""country"": ""South Korea"",
      ""ranking"": {
        ""current_aqi"": 76,
        ""current_aqi_cn"": 34
      }
    },
    {
      ""city"": ""Paris"",
      ""state"": ""Ile-de-France"",
      ""country"": ""France"",
      ""ranking"": {
        ""current_aqi"": 75,
        ""current_aqi_cn"": 33
      }
    },
    {
      ""city"": ""Riyadh"",
      ""state"": ""Riyadh"",
      ""country"": ""Saudi Arabia"",
      ""ranking"": {
        ""current_aqi"": 74,
        ""current_aqi_cn"": 33,
        ""last_aqi"": 85,
        ""last_aqi_cn"": 40
      }
    },
    {
      ""city"": ""Wroclaw"",
      ""state"": ""Wroclaw"",
      ""country"": ""Poland"",
      ""ranking"": {
        ""current_aqi"": 71,
        ""current_aqi_cn"": 31
      }
    },
    {
      ""city"": ""Denver"",
      ""state"": ""Colorado"",
      ""country"": ""USA"",
      ""ranking"": {
        ""current_aqi"": 70,
        ""current_aqi_cn"": 30
      }
    },
    {
      ""city"": ""Tehran"",
      ""state"": ""Tehran"",
      ""country"": ""Iran"",
      ""ranking"": {
        ""current_aqi"": 69,
        ""current_aqi_cn"": 30
      }
    },
    {
      ""city"": ""Kuala Lumpur"",
      ""state"": ""Wilayah Persekutuan"",
      ""country"": ""Malaysia"",
      ""ranking"": {
        ""current_aqi"": 69,
        ""current_aqi_cn"": 30,
        ""last_aqi"": 70,
        ""last_aqi_cn"": 30
      }
    },
    {
      ""city"": ""Oakland"",
      ""state"": ""California"",
      ""country"": ""USA"",
      ""ranking"": {
        ""current_aqi"": 63,
        ""current_aqi_cn"": 26
      }
    },
    {
      ""city"": ""Incheon"",
      ""state"": ""Gyeonggi-do"",
      ""country"": ""South Korea"",
      ""ranking"": {
        ""current_aqi"": 63,
        ""current_aqi_cn"": 25
      }
    },
    {
      ""city"": ""Sacramento"",
      ""state"": ""California"",
      ""country"": ""USA"",
      ""ranking"": {
        ""current_aqi"": 61,
        ""current_aqi_cn"": 24
      }
    },
    {
      ""city"": ""Los Angeles"",
      ""state"": ""California"",
      ""country"": ""USA"",
      ""ranking"": {
        ""current_aqi"": 59,
        ""current_aqi_cn"": 23
      }
    },
    {
      ""city"": ""Busan"",
      ""state"": ""Gyeongsangnam-do"",
      ""country"": ""South Korea"",
      ""ranking"": {
        ""current_aqi"": 59,
        ""current_aqi_cn"": 23
      }
    },
    {
      ""city"": ""Hong Kong"",
      ""state"": ""Hong Kong"",
      ""country"": ""China"",
      ""ranking"": {
        ""current_aqi"": 58,
        ""current_aqi_cn"": 22
      }
    },
    {
      ""city"": ""San Francisco"",
      ""state"": ""California"",
      ""country"": ""USA"",
      ""ranking"": {
        ""current_aqi"": 58,
        ""current_aqi_cn"": 22
      }
    },
    {
      ""city"": ""Nice"",
      ""state"": ""PACA"",
      ""country"": ""France"",
      ""ranking"": {
        ""current_aqi"": 57,
        ""current_aqi_cn"": 21
      }
    },
    {
      ""city"": ""Shanghai"",
      ""state"": ""Shanghai"",
      ""country"": ""China"",
      ""ranking"": {
        ""current_aqi"": 55,
        ""current_aqi_cn"": 20
      }
    },
    {
      ""city"": ""Karachi"",
      ""state"": ""Sindh"",
      ""country"": ""Pakistan"",
      ""ranking"": {
        ""current_aqi"": 55,
        ""current_aqi_cn"": 20,
        ""last_aqi"": 55,
        ""last_aqi_cn"": 20
      }
    },
    {
      ""city"": ""Tel Aviv-Yafo"",
      ""state"": ""Tel Aviv District"",
      ""country"": ""Israel"",
      ""ranking"": {
        ""current_aqi"": 54,
        ""current_aqi_cn"": 20
      }
    },
    {
      ""city"": ""Krakow"",
      ""state"": ""krakow"",
      ""country"": ""Poland"",
      ""ranking"": {
        ""current_aqi"": 51,
        ""current_aqi_cn"": 17
      }
    },
    {
      ""city"": ""London"",
      ""state"": ""Greater London"",
      ""country"": ""United Kingdom"",
      ""ranking"": {
        ""current_aqi"": 51,
        ""current_aqi_cn"": 17
      }
    },
    {
      ""city"": ""Pristina"",
      ""state"": ""Kosovo"",
      ""country"": ""Kosovo"",
      ""ranking"": {
        ""current_aqi"": 50,
        ""current_aqi_cn"": 17
      }
    },
    {
      ""city"": ""Bakersfield"",
      ""state"": ""California"",
      ""country"": ""USA"",
      ""ranking"": {
        ""current_aqi"": 50,
        ""current_aqi_cn"": 17
      }
    },
    {
      ""city"": ""Newark"",
      ""state"": ""New Jersey"",
      ""country"": ""USA"",
      ""ranking"": {
        ""current_aqi"": 49,
        ""current_aqi_cn"": 17
      }
    },
    {
      ""city"": ""Warsaw"",
      ""state"": ""Mazowieckie"",
      ""country"": ""Poland"",
      ""ranking"": {
        ""current_aqi"": 49,
        ""current_aqi_cn"": 17
      }
    },
    {
      ""city"": ""Poznan"",
      ""state"": ""Poznan"",
      ""country"": ""Poland"",
      ""ranking"": {
        ""current_aqi"": 49,
        ""current_aqi_cn"": 17
      }
    },
    {
      ""city"": ""Kaohsiung"",
      ""state"": ""Kaohsiung"",
      ""country"": ""Taiwan"",
      ""ranking"": {
        ""current_aqi"": 46,
        ""current_aqi_cn"": 16
      }
    },
    {
      ""city"": ""Singapore"",
      ""state"": ""Singapore"",
      ""country"": ""Singapore"",
      ""ranking"": {
        ""current_aqi"": 45,
        ""current_aqi_cn"": 16
      }
    },
    {
      ""city"": ""Kosice"",
      ""state"": ""Kosice"",
      ""country"": ""Slovakia"",
      ""ranking"": {
        ""current_aqi"": 45,
        ""current_aqi_cn"": 16
      }
    },
    {
      ""city"": ""Bangkok"",
      ""state"": ""Bangkok"",
      ""country"": ""Thailand"",
      ""ranking"": {
        ""current_aqi"": 44,
        ""current_aqi_cn"": 15
      }
    },
    {
      ""city"": ""Manila"",
      ""state"": ""National Capital Region"",
      ""country"": ""Philippines"",
      ""ranking"": {
        ""current_aqi"": 43,
        ""current_aqi_cn"": 15
      }
    },
    {
      ""city"": ""Escaldes-Engordany"",
      ""state"": ""andorra"",
      ""country"": ""Andorra"",
      ""ranking"": {
        ""current_aqi"": 43,
        ""current_aqi_cn"": 33,
        ""last_aqi"": 47,
        ""last_aqi_cn"": 36
      }
    },
    {
      ""city"": ""Munich"",
      ""state"": ""Bavaria"",
      ""country"": ""Germany"",
      ""ranking"": {
        ""current_aqi"": 35,
        ""current_aqi_cn"": 27,
        ""last_aqi"": 44,
        ""last_aqi_cn"": 33
      }
    },
    {
      ""city"": ""Brussels"",
      ""state"": ""Brussels"",
      ""country"": ""Belgium"",
      ""ranking"": {
        ""current_aqi"": 33,
        ""current_aqi_cn"": 11
      }
    },
    {
      ""city"": ""Budapest"",
      ""state"": ""Central Hungary"",
      ""country"": ""Hungary"",
      ""ranking"": {
        ""current_aqi"": 33,
        ""current_aqi_cn"": 43,
        ""last_aqi"": 30,
        ""last_aqi_cn"": 43
      }
    },
    {
      ""city"": ""Vilnius"",
      ""state"": ""Vilniaus apskritis"",
      ""country"": ""Lithuania"",
      ""ranking"": {
        ""current_aqi"": 33,
        ""current_aqi_cn"": 11
      }
    },
    {
      ""city"": ""Madrid"",
      ""state"": ""Madrid"",
      ""country"": ""Spain"",
      ""ranking"": {
        ""current_aqi"": 29,
        ""current_aqi_cn"": 10
      }
    },
    {
      ""city"": ""Amsterdam"",
      ""state"": ""Noord-Holland"",
      ""country"": ""Netherlands"",
      ""ranking"": {
        ""current_aqi"": 26,
        ""current_aqi_cn"": 9
      }
    },
    {
      ""city"": ""Toronto Downtown"",
      ""state"": ""Ontario"",
      ""country"": ""Canada"",
      ""ranking"": {
        ""current_aqi"": 25,
        ""current_aqi_cn"": 9
      }
    },
    {
      ""city"": ""Prague"",
      ""state"": ""Prague"",
      ""country"": ""Czech Republic"",
      ""ranking"": {
        ""current_aqi"": 23,
        ""current_aqi_cn"": 8
      }
    },
    {
      ""city"": ""Moscow"",
      ""state"": ""Moscow"",
      ""country"": ""Russia"",
      ""ranking"": {
        ""current_aqi"": 22,
        ""current_aqi_cn"": 8
      }
    },
    {
      ""city"": ""Lisbon"",
      ""state"": ""Lisbon"",
      ""country"": ""Portugal"",
      ""ranking"": {
        ""current_aqi"": 21,
        ""current_aqi_cn"": 7
      }
    },
    {
      ""city"": ""Bratislava"",
      ""state"": ""Bratislava"",
      ""country"": ""Slovakia"",
      ""ranking"": {
        ""current_aqi"": 20,
        ""current_aqi_cn"": 22,
        ""last_aqi"": 14,
        ""last_aqi_cn"": 15
      }
    },
    {
      ""city"": ""Ulaanbaatar"",
      ""state"": ""Ulaanbaatar"",
      ""country"": ""Mongolia"",
      ""ranking"": {
        ""current_aqi"": 19,
        ""current_aqi_cn"": 7
      }
    },
    {
      ""city"": ""Detroit"",
      ""state"": ""Michigan"",
      ""country"": ""USA"",
      ""ranking"": {
        ""current_aqi"": 19,
        ""current_aqi_cn"": 7
      }
    },
    {
      ""city"": ""Phnom Penh"",
      ""state"": ""Phnom Penh"",
      ""country"": ""Cambodia"",
      ""ranking"": {
        ""current_aqi"": 19,
        ""current_aqi_cn"": 6,
        ""last_aqi"": 20,
        ""last_aqi_cn"": 7
      }
    },
    {
      ""city"": ""Jerusalem"",
      ""state"": ""Jerusalem District"",
      ""country"": ""Israel"",
      ""ranking"": {
        ""current_aqi"": 17,
        ""current_aqi_cn"": 6
      }
    },
    {
      ""city"": ""Rotterdam"",
      ""state"": ""Zuid-Holland"",
      ""country"": ""Netherlands"",
      ""ranking"": {
        ""current_aqi"": 16,
        ""current_aqi_cn"": 6
      }
    },
    {
      ""city"": ""Matosinhos"",
      ""state"": ""Porto"",
      ""country"": ""Portugal"",
      ""ranking"": {
        ""current_aqi"": 15,
        ""current_aqi_cn"": 16,
        ""last_aqi"": 15,
        ""last_aqi_cn"": 16
      }
    },
    {
      ""city"": ""Vienna"",
      ""state"": ""Vienna"",
      ""country"": ""Austria"",
      ""ranking"": {
        ""current_aqi"": 15,
        ""current_aqi_cn"": 5
      }
    },
    {
      ""city"": ""Sydney"",
      ""state"": ""New South Wales"",
      ""country"": ""Australia"",
      ""ranking"": {
        ""current_aqi"": 14,
        ""current_aqi_cn"": 5
      }
    },
    {
      ""city"": ""Bern"",
      ""state"": ""Bern"",
      ""country"": ""Switzerland"",
      ""ranking"": {
        ""current_aqi"": 14,
        ""current_aqi_cn"": 20,
        ""last_aqi"": 14,
        ""last_aqi_cn"": 20
      }
    },
    {
      ""city"": ""Helsinki"",
      ""state"": ""Uusimaa"",
      ""country"": ""Finland"",
      ""ranking"": {
        ""current_aqi"": 13,
        ""current_aqi_cn"": 4
      }
    },
    {
      ""city"": ""Oslo"",
      ""state"": ""Oslo"",
      ""country"": ""Norway"",
      ""ranking"": {
        ""current_aqi"": 13,
        ""current_aqi_cn"": 5
      }
    },
    {
      ""city"": ""Ankara"",
      ""state"": ""Ankara"",
      ""country"": ""Turkey"",
      ""ranking"": {
        ""current_aqi"": 12,
        ""current_aqi_cn"": 13,
        ""last_aqi"": 18,
        ""last_aqi_cn"": 20
      }
    },
    {
      ""city"": ""Katowice"",
      ""state"": ""Slaskie"",
      ""country"": ""Poland"",
      ""ranking"": {
        ""current_aqi"": 10,
        ""current_aqi_cn"": 3
      }
    },
    {
      ""city"": ""Beograd"",
      ""state"": ""Central Serbia"",
      ""country"": ""Serbia"",
      ""ranking"": {
        ""current_aqi"": 10,
        ""current_aqi_cn"": 4
      }
    },
    {
      ""city"": ""Zagreb"",
      ""state"": ""Croatia"",
      ""country"": ""Croatia"",
      ""ranking"": {
        ""current_aqi"": 9,
        ""current_aqi_cn"": 19,
        ""last_aqi"": 7,
        ""last_aqi_cn"": 17
      }
    },
    {
      ""city"": ""Richards Bay"",
      ""state"": ""KwaZulu-Natal"",
      ""country"": ""South Africa"",
      ""ranking"": {
        ""current_aqi"": 3,
        ""current_aqi_cn"": 3,
        ""last_aqi"": 5,
        ""last_aqi_cn"": 5
      }
    }
  ]
}";
    
    //400
    public static string GetBadRequestResponse =>
        @"{""status"":""fail"",""data"":{""message"":""permission_denied (you don't have access to this endpoint""}}";
    
    public static string GetErrorForbiddenResponse => @"{""status"":""fail"",""data"":{""message"":""Forbidden""}}";
}