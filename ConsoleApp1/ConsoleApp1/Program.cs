#region E-mail ünvanının yoxlanılması

//void EmailValidator (string email)
//{
//	if (email.Contains("@") && email.Contains(".com"))
//	{
//		Console.WriteLine("Duzgun format");
//	}
//	else {
//		Console.WriteLine("Yanlis format");
//			}
//}
//EmailValidator("kerimli@gmail.com");

#endregion

#region Cümlədə müəyyən sözün dəyişdirilməsi

//string Text = Console.ReadLine();
//string SelectedText = Console.ReadLine();
//string EditedText= Console.ReadLine();

//void StringChanger (string text1 ,string text2)
//{
//	string result = Text.Replace(text1, text2);

//	Console.WriteLine("Yeni cumle: " + result);

//}
//StringChanger(SelectedText, EditedText);
#endregion

#region İstifadəçi adının yaradılması

//Console.Write("Adınızı daxil edin: ");
//string ad = Console.ReadLine()!.Trim();

//Console.Write("Soyadınızı daxil edin: ");
//string soyad = Console.ReadLine()!.Trim();

//if (ad.Length >= 3 && soyad.Length >= 3)
//{
//	string username = (ad.Substring(0, 3) + soyad.Substring(0, 3)).ToLower();

//	Console.WriteLine("Username: " + username);
//}
//else
//{
//	Console.WriteLine("Ad və soyad ən azı 3 simvoldan ibarət olmalıdır.");
//}

#endregion

#region  Massivdə təkrarlanan ədədləri müəyyən edin
int[] numbers = { 3, 7, 3, 9, 7, 5, 3 };

for (int i = 0; i < numbers.Length; i++)
{
	bool tekrar = false;

	for (int j = 0; j < i; j++)
	{
		if (numbers[i] == numbers[j])
		{
			tekrar = true;
		}
	}

	if (tekrar == false)
	{
		int say = 0;

		for (int j = 0; j < numbers.Length; j++)
		{
			if (numbers[i] == numbers[j])
			{
				say++;
			}
		}

		if (say > 1)
		{
			Console.WriteLine(numbers[i]);
		}
	}
}
#endregion

#region Massivdə mənfi ədədləri sıfırlayın

//int[] numbers = { 5, -3, 8, -1, 12, -7 };

//for (int i = 0; i < numbers.Length; i++)
//{
//	if (numbers[i] < 0)
//	{
//		numbers[i] = 0;
//	}
//}

//Console.Write("Yeni massiv: ");

//for (int i = 0; i < numbers.Length; i++)
//{
//	Console.Write(numbers[i] + " ");
//}

#endregion


#region  Mətnin palindrom olub-olmadığını yoxlayın

//Console.Write("Mətn daxil edin: ");
//string text = Console.ReadLine()!.ToLower();

//bool palindromdur = true;

//for (int i = 0; i < text.Length / 2; i++)
//{
		
//}

//if (palindromdur)
//{
//	Console.WriteLine("Mətn palindromdur.");
//}
//else
//{
//	Console.WriteLine("Mətn palindrom deyil.");
//}

#endregion



