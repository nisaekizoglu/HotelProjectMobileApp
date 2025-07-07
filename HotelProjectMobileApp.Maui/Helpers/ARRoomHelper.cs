using SkiaSharp;

namespace HotelProjectMobileApp.Maui.Helpers;

public static class ARRoomHelper
{
    public static class RoomTypes
    {
        public const string Mountain = "mountain";
        public const string Sea = "sea";
        public const string Suite = "suite";
    }

    public static class RoomColors
    {
        public static SKColor GetWallColor(string roomType)
        {
            return roomType switch
            {
                RoomTypes.Mountain => SKColors.LightBlue,
                RoomTypes.Sea => SKColors.Beige,
                RoomTypes.Suite => SKColors.Gold,
                _ => SKColors.Beige
            };
        }

        public static SKColor GetFloorColor(string roomType)
        {
            return roomType switch
            {
                RoomTypes.Mountain => SKColors.DarkGreen,
                RoomTypes.Sea => SKColors.BurlyWood,
                RoomTypes.Suite => SKColors.DarkRed,
                _ => SKColors.BurlyWood
            };
        }

        public static SKColor GetFurnitureColor(string roomType)
        {
            return roomType switch
            {
                RoomTypes.Mountain => SKColors.Brown,
                RoomTypes.Sea => SKColors.White,
                RoomTypes.Suite => SKColors.Black,
                _ => SKColors.White
            };
        }
    }

    public static class RoomFeatures
    {
        public static string GetRoomDescription(string roomType)
        {
            return roomType switch
            {
                RoomTypes.Mountain => "Dağ manzaralı odada doğayla iç içe huzurlu bir tatil deneyimi",
                RoomTypes.Sea => "Deniz manzaralı odada mavi suların huzuru",
                RoomTypes.Suite => "Lüks suit odada ayrıcalıklı konfor ve hizmet",
                _ => "Konforlu ve huzurlu bir tatil deneyimi"
            };
        }

        public static string GetRoomFeatures(string roomType)
        {
            return roomType switch
            {
                RoomTypes.Mountain => "• Dağ manzarası\n• Balkon\n• Şömine\n• Doğa sesleri",
                RoomTypes.Sea => "• Deniz manzarası\n• Geniş pencere\n• Balkon\n• Deniz sesleri",
                RoomTypes.Suite => "• Lüks dekorasyon\n• Oturma alanı\n• Jacuzzi\n• Özel hizmet",
                _ => "• Konforlu yatak\n• Modern dekorasyon\n• Temiz ortam"
            };
        }
    }

    public static class AnimationHelper
    {
        public static float EaseInOut(float t)
        {
            return t < 0.5f ? 2f * t * t : -1f + (4f - 2f * t) * t;
        }

        public static float Lerp(float start, float end, float t)
        {
            return start + (end - start) * t;
        }

        public static SKPoint Lerp(SKPoint start, SKPoint end, float t)
        {
            return new SKPoint(
                Lerp(start.X, end.X, t),
                Lerp(start.Y, end.Y, t)
            );
        }
    }
} 