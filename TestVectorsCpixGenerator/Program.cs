using Axinom.Cpix;
using System;
using System.Collections.Generic;

namespace TestVectorsCpixGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			// https://github.com/Axinom/dash-test-vectors
			GenerateCpix("Axinom-v7-ContentKeys.xml", new Dictionary<Guid, byte[]>
			{
				{ new Guid("9eb4050d-e44b-4802-932e-27d75083e266"), Convert.FromBase64String("FmY0xnWCPCNaSpRG+tUuTQ==") },

				{ new Guid("80399bf5-8a21-4014-8053-e27e748e98c0"), Convert.FromBase64String("3aHppzZ2g3Y3wK1uNnUXmg==") },
				{ new Guid("90953e09-6cb2-49a3-a260-7a5fefead499"), Convert.FromBase64String("zsmKW7Mq9Unz5R7oUGeF8w==") },
				{ new Guid("0e4da92b-d0e8-4a66-8c3f-c25a97eb6532"), Convert.FromBase64String("UmYYfGb7znuoFAQM79ayHw==") },
				{ new Guid("585f233f-3072-46f1-9fa4-6dc22c66a014"), Convert.FromBase64String("jayKpC3tmPq4YKXkapa8FA==") },
				{ new Guid("4222bd78-bc45-41bf-b63e-6f814dc391df"), Convert.FromBase64String("GAMi9v92b9ca5yBwaptN+Q==") },

				{ new Guid("0872786e-f9e7-465f-a3a2-4e5b0ef8fa45"), Convert.FromBase64String("wyYRebq2Hu7JedLUBpURzw==") },
				{ new Guid("c14f0709-f2b9-4427-916b-61b52586506a"), Convert.FromBase64String("7fsXeXJHs8enQ0SEfkhTBQ==") },
				{ new Guid("8b029e51-d56a-44bd-910f-d4b5fd90fba2"), Convert.FromBase64String("yInMol6zCzsSjrg06k2k+g==") },
				{ new Guid("2d6e9387-60ca-4145-aec2-c40837b4b026"), Convert.FromBase64String("QtC/8bYPe+SfF9YDSE0MuQ==") },
				{ new Guid("de02f07f-a098-4ee0-b556-907c0d17fbbc"), Convert.FromBase64String("GQnGyyKBez4x8aNTD6cNzw==") },
				{ new Guid("914e69f4-0ab3-4534-9e9f-9853615e26f6"), Convert.FromBase64String("0DBllUYESc5WdSJMebqlBA==") },
				{ new Guid("da4445c2-db5e-48ef-b096-3ef347b16c7f"), Convert.FromBase64String("0aUpR1ASGSQ1UGxWxY7ozA==") },
				{ new Guid("29f05e8f-a1ae-46e4-80e9-22dcd44cd7a1"), Convert.FromBase64String("BxGxfISpDLtBCXJkyQG3Mg==") },
				{ new Guid("69fe7077-dadd-4b55-96cd-c3edb3991853"), Convert.FromBase64String("7TqCUJKmSlCbdIeJ0xbAgQ==") },
			});

			// https://github.com/Axinom/dash-test-vectors/tree/conservative
			GenerateCpix("Axinom-v6.1-ContentKeys.xml", new Dictionary<Guid, byte[]>
			{
				{ new Guid("6e5a1d26-2757-47d7-8046-eaa5d1d34b5a"), Convert.FromBase64String("GX8m9XLIZNIzizrl0RTqnA==") },

				{ new Guid("1530d3a0-6904-446a-91a1-33a115aa8c41"), Convert.FromBase64String("ubafkhpLoQF0nyvzzouLpg==") },
				{ new Guid("c83eb639-e664-43f8-ae98-4039b0c13b2d"), Convert.FromBase64String("f5p7XvhuXKve9gx/v2pUsg==") },
				{ new Guid("3d8cc762-27ac-400f-989f-8ab5dc7d7775"), Convert.FromBase64String("cRc6/royDmsPA3zKGkQ81w==") },
				{ new Guid("bd8dad58-032d-4c25-89fa-c7b710e82ac2"), Convert.FromBase64String("gDfgWVfz6O0Kq0+ZAV1miw==") },

				{ new Guid("53be7757-7288-4b6b-b20a-f05b64a4ef79"), Convert.FromBase64String("/34ZeGgb0eDY4M7FD12vcg==") },
				{ new Guid("0ed821a8-80ed-40ac-a804-927c9fdadbe9"), Convert.FromBase64String("/6zlZEjHG0Ov698JfdL7aA==") },
				{ new Guid("e47d78ca-94dc-45fb-9e3d-2a773aef74b2"), Convert.FromBase64String("3ZTeftObJfIHZeDvHAbarw==") },
				{ new Guid("32a141e9-23ab-44ff-a6c7-5349c89451cf"), Convert.FromBase64String("qtC6/ovJfAVxoQDFLh5knQ==") },
				{ new Guid("8d091966-44b5-4cf8-8a45-ed12fdb18d35"), Convert.FromBase64String("Da70PZt6XWYOdNDcJdqCBw==") },
			});
		}

		static void GenerateCpix(string name, IReadOnlyDictionary<Guid, byte[]> keys)
		{
			var document = new CpixDocument();

			foreach (var pair in keys)
			{
				document.ContentKeys.Add(new ContentKey
				{
					Id = pair.Key,
					Value = pair.Value
				});
			}

			document.Save(name);
		}
	}
}
