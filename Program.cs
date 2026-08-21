using ingot.Core;
using PropsAndFurnituresAddOnCity.Content.Blocks;

const string packUuid = "77f1fef2-bb39-411a-b25c-ae475c21169f";
string dataDir = Path.Combine(AppContext.BaseDirectory, "Data");

Pack pack = Pack.Create(packUuid, "Props And Furnitures Add-On City", "Addon Created By RMPlaysMCYT, Created using Ingot by Pyroboost")
    .AddBlock<CityChair1>()              // textures declared on the block class
    // .AddItem<MyItem>()                // icon path declared on the item class
    .AddEntity<RoboticBin>();
    // .AddClientEntity<MyClientEntity>(); // materials / textures / geometry short-names

pack.PackIcon = Path.Combine(dataDir, "pack_icon.png");

pack.Compile("./output");