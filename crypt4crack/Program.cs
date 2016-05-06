using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace crypt4crack
{
	class MainClass
	{
		static string c_name = "Crypt4Crack";
		static string c_version = "1.0";
		static string c_url = "";

		static string c_info = c_name + " V" + c_version + " " + c_url;

		public static void Main (string[] args)
		{
			switch (args.Length) {
			case 0:
				Console.WriteLine ("\n\n\n\n\n");
				Console.WriteLine (c_info);
				Console.WriteLine ("");
				Console.WriteLine ("-g run gui");
				Console.WriteLine ("-h help");
				Console.WriteLine ("-v show version");
				Console.WriteLine ("");
				Console.WriteLine ("");
				break;
			case 1:
				switch (args[0]) {
				case "-g":
					run ();
					break;
				case "-h":
					help ();
					break;
				case "-v":
					s_version ();
					break;
				default:
					Console.WriteLine ("\n\n\n\n\n");
					Console.WriteLine (c_info);
					Console.WriteLine ("");
					Console.WriteLine ("-g run gui");
					Console.WriteLine ("-h help");
					Console.WriteLine ("-v show version");
					Console.WriteLine ("");
					Console.WriteLine ("");
					break;
				}
				break;
			case 2:
				StreamWriter swr = new StreamWriter ("cracked_keys.txt", true);
				Stopwatch stw = new Stopwatch();
				switch (args [0]) {
				case "-md5":
					if (args [1].Length.Equals (32)) {
						string s = "", h = "";
						stw.Start();
						while ((s = Console.ReadLine ()) != null) {
							h = get_md5 (s);
							Console.WriteLine ("CHECKING: " + s + "   MD5 Hash: " + h);
							if (args [1].Equals (h)) {
								Console.WriteLine ("\n\n\nMD5 CRACKED\n");
								Console.WriteLine ("Password: " + s + "   MD5 Hash: " + h);
								swr.WriteLine ("Password: " + s + "   MD5 Hash: " + h);
								break;
							}
						}
						stw.Stop ();
						Console.WriteLine ("\n\nTime Elapsed = {0}", stw.Elapsed);
					} else {
						Console.WriteLine ("");
						Console.WriteLine ("");
						Console.WriteLine ("WARNING!!! HASH INCOMPLETE!!!");
						Console.WriteLine ("");
						Console.WriteLine ("MD5 Hash length " + args [1].Length + ", must be 32");
					}
					break;
				case "-sha1":
					if (args [1].Length.Equals (40)) {
						string s = "", h = "";
						stw.Start();
						while ((s = Console.ReadLine ()) != null) {
							h = get_sha1 (s);
							Console.WriteLine ("CHECKING: " + s + "   SHA1 Hash: " + h);
							if (args [1].Equals (h)) {
								Console.WriteLine ("\n\n\nSHA1 CRACKED\n");
								Console.WriteLine ("Password: " + s + "   SHA1 Hash: " + h);
								swr.WriteLine ("Password: " + s + "   SHA1 Hash: " + h);
								break;
							}
						}
						stw.Stop ();
						Console.WriteLine ("\n\nTime Elapsed = {0}", stw.Elapsed);
					} else {
						Console.WriteLine ("");
						Console.WriteLine ("");
						Console.WriteLine ("WARNING!!! HASH INCOMPLETE!!!");
						Console.WriteLine ("");
						Console.WriteLine ("SHA1 Hash length " + args [1].Length + ", must be 40");
					}
					break;
				case "-sha256":
					if (args [1].Length.Equals (64)) {
						string s = "", h = "";
						stw.Start();
						while ((s = Console.ReadLine ()) != null) {
							h = get_sha256 (s);
							Console.WriteLine ("CHECKING: " + s + "   SHA256 Hash: " + h);
							if (args [1].Equals (h)) {
								Console.WriteLine ("\n\n\nSHA256 CRACKED\n");
								Console.WriteLine ("Password: " + s + "   SHA256 Hash: " + h);
								swr.WriteLine ("Password: " + s + "   SHA256 Hash: " + h);
								break;
							}
						}
						stw.Stop ();
						Console.WriteLine ("\n\nTime Elapsed = {0}", stw.Elapsed);
					} else {
						Console.WriteLine ("");
						Console.WriteLine ("");
						Console.WriteLine ("WARNING!!! HASH INCOMPLETE!!!");
						Console.WriteLine ("");
						Console.WriteLine ("SHA256 Hash length " + args [1].Length + ", must be 40");
					}
					break;
				case "-sha384":
					if (args [1].Length.Equals (96)) {
						string s = "", h = "";
						stw.Start();
						while ((s = Console.ReadLine ()) != null) {
							h = get_sha384 (s);
							Console.WriteLine ("CHECKING: " + s + "   SHA384 Hash: " + h);
							if (args [1].Equals (h)) {
								Console.WriteLine ("\n\n\nSHA384 CRACKED\n");
								Console.WriteLine ("Password: " + s + "   SHA384 Hash: " + h);
								swr.WriteLine ("Password: " + s + "   SHA384 Hash: " + h);
								break;
							}
						}
						stw.Stop ();
						Console.WriteLine ("\n\nTime Elapsed = {0}", stw.Elapsed);
					} else {
						Console.WriteLine ("");
						Console.WriteLine ("");
						Console.WriteLine ("WARNING!!! HASH INCOMPLETE!!!");
						Console.WriteLine ("");
						Console.WriteLine ("SHA384 Hash length " + args [1].Length + ", must be 40");
					}
					break;
				case "-sha512":
					if (args [1].Length.Equals (128)) {
						string s = "", h = "";
						stw.Start();
						while ((s = Console.ReadLine ()) != null) {
							h = get_sha512 (s);
							Console.WriteLine ("CHECKING: " + s + "   SHA512 Hash: " + h);
							if (args [1].Equals (h)) {
								Console.WriteLine ("\n\n\nSHA512 CRACKED\n");
								Console.WriteLine ("Password: " + s + "   SHA512 Hash: " + h);
								swr.WriteLine ("Password: " + s + "   SHA512 Hash: " + h);
								break;
							}
						}
						stw.Stop ();
						Console.WriteLine ("\n\nTime Elapsed = {0}", stw.Elapsed);
					} else {
						Console.WriteLine ("");
						Console.WriteLine ("");
						Console.WriteLine ("WARNING!!! HASH INCOMPLETE!!!");
						Console.WriteLine ("");
						Console.WriteLine ("SHA512 Hash length " + args [1].Length + ", must be 40");
					}
					break;
				}
				swr.Close ();
				break;
			default:
				
				break;
			}//END SWITCH 1
		}//END MAIN

	
		public static void run (){
			while (true) {
				for (int i = 0; i <= 60; i++) {
					Console.WriteLine ("");
				}
				Console.WriteLine (c_info);
				Console.WriteLine ("");
				Console.WriteLine (" 1-Get Hash");
				Console.WriteLine (" 2-Get Source");
				Console.WriteLine (" q-Exit");
				Console.Write ("\n> ");
				string opt = Console.ReadLine ();
				Console.WriteLine ("\n________________________\n\n");
				switch (opt) {
				case "1":
					Console.Write ("String To Hash > ");
					string s = Console.ReadLine ();
					Console.WriteLine ("\n________________________\n\n");
					Console.WriteLine ("Hash to...\n");
					Console.WriteLine (" 1-MD5");
					Console.WriteLine (" 2-SHA1");
					Console.WriteLine (" 3-SHA256");
					Console.WriteLine (" 4-SHA384");
					Console.WriteLine (" 5-SHA512");
					Console.WriteLine (" 6-ALL");
					Console.WriteLine (" q-Exit");
					Console.Write ("\n> ");
					string o = Console.ReadLine ();
					Console.WriteLine ("\n________________________\n\n");
					StreamWriter sw = new StreamWriter ("gen_keys.txt", true);

					switch (o) {
					case "1":
						Console.WriteLine ("Password: " + s + "	MD5 HASH: " + get_md5 (s));
						sw.WriteLine ("Password: " + s + "	MD5 HASH: " + get_md5 (s));
						break;
					case "2":
						Console.WriteLine ("Password: " + s + "	SHA1 HASH: " + get_sha1 (s));
						sw.WriteLine ("Password: " + s + "	SHA1 HASH: " + get_sha1 (s));
						break;
					case "3":
						Console.WriteLine ("Password: " + s + "	SHA256 HASH: " + get_sha256 (s));
						sw.WriteLine ("Password: " + s + "	SHA256 HASH: " + get_sha256 (s));
						break;
					case "4":
						Console.WriteLine ("Password: " + s + "	SHA384 HASH: " + get_sha384 (s));
						sw.WriteLine ("Password: " + s + "	SHA384 HASH: " + get_sha384 (s));
						break;
					case "5":
						Console.WriteLine ("Password: " + s + "	SHA512 HASH: " + get_sha512 (s));
						sw.WriteLine ("Password: " + s + "	SHA512 HASH: " + get_sha512 (s));
						break;
					case "6":
						Console.WriteLine ("Password: " + s + "	MD5 HASH: " + get_md5 (s));
						sw.WriteLine ("Password: " + s + "	MD5 HASH: " + get_md5 (s));
						Console.WriteLine ("Password: " + s + "	SHA1 HASH: " + get_sha1 (s));
						sw.WriteLine ("Password: " + s + "	SHA1 HASH: " + get_sha1 (s));
						Console.WriteLine ("Password: " + s + "	SHA256 HASH: " + get_sha256 (s));
						sw.WriteLine ("Password: " + s + "	SHA256 HASH: " + get_sha256 (s));
						Console.WriteLine ("Password: " + s + "	SHA384 HASH: " + get_sha384 (s));
						sw.WriteLine ("Password: " + s + "	SHA384 HASH: " + get_sha384 (s));
						Console.WriteLine ("Password: " + s + "	SHA512 HASH: " + get_sha512 (s));
						sw.WriteLine ("Password: " + s + "	SHA512 HASH: " + get_sha512 (s));
						break;
					case "q":
						Console.WriteLine ("Goodbye");
						return;
					default:
						break;
					}


					sw.Close ();
					Console.WriteLine ("\nSaved as \'gen_keys.txt\'");
					Console.Write ("\nPress enter to continue. . .");
					Console.ReadLine ();
					break;


				case "2":
					StreamReader file;

					while (true) {
						Console.Write ("Dictionary > ");
						string dic = Console.ReadLine (); //absolute route
						try {
							file = new System.IO.StreamReader (dic);
							if (dic != "") {
								break;
							}
						} catch {
							Console.WriteLine ("\nWARNING select an existing file");
						}
					}


					Console.Write ("Hash to crack > ");
					string hc = Console.ReadLine ();
					for (int i = 0; i <= 60; i++) {
						Console.WriteLine ("");
					}
					Console.WriteLine ("\nIdentifying hash...");
					Stopwatch stw = new Stopwatch ();
					//StreamWriter sw2 = new StreamWriter ("cracked_keys.txt", true);
					StreamWriter sw2;
					string sr = "";
					switch (hc.Length) {
					case 32:
						Console.Write ("Seems a MD5 Hash, is it? (y/n): ");
						sr = Console.ReadLine ();
						if ((sr.Equals ("y")) || (sr.Equals (""))){
							sw2 = new StreamWriter ("cracked_keys.txt", true);
							string ss = "", h = "";
							stw.Start();
							while ((ss = file.ReadLine()) != null) {
								h = get_md5 (ss);
								Console.WriteLine ("CHECKING: " + ss + "   MD5 Hash: " + h);
								if (hc.Equals (h)) {
									Console.WriteLine ("\n\n\nMD5 CRACKED\n");
									Console.WriteLine ("Password: " + ss + "   MD5 Hash: " + h);
									sw2.WriteLine ("Password: " + ss + "   MD5 Hash: " + h);
									sw2.Close ();
									stw.Stop ();
									Console.WriteLine ("\n\nTime Elapsed = {0}", stw.Elapsed);
									Console.WriteLine ("\n\nPress enter to continue . . .");
									Console.ReadLine();
									break;
								}
							}
							stw.Stop ();
							Console.WriteLine ("\n\nTime Elapsed = {0}", stw.Elapsed);
						} else {
							Console.Write ("\nWARNING check the input hash\n");
							return;
						}
						break;
					case 40:
						Console.Write ("Seems a SHA1 Hash, is it? (y/n): ");
						sr = Console.ReadLine ();
						if ((sr.Equals ("y")) || (sr.Equals (""))){
							sw2 = new StreamWriter ("cracked_keys.txt", true);
							string ss = "", h = "";
							stw.Start();
							while ((ss = file.ReadLine()) != null) {
								h = get_sha1 (ss);
								Console.WriteLine ("CHECKING: " + ss + "   SHA1 Hash: " + h);
								if (hc.Equals (h)) {
									Console.WriteLine ("\n\n\nSHA1 CRACKED\n");
									Console.WriteLine ("Password: " + ss + "   SHA1 Hash: " + h);
									sw2.WriteLine ("Password: " + ss + "   SHA1 Hash: " + h);
									sw2.Close ();
									stw.Stop ();
									Console.WriteLine ("\n\nTime Elapsed = {0}", stw.Elapsed);
									Console.WriteLine ("\n\nPress enter to continue . . .");
									Console.ReadLine();
									break;
								}
							}
							stw.Stop ();
							Console.WriteLine ("\n\nTime Elapsed = {0}", stw.Elapsed);
						} else {
							Console.Write ("\nWARNING check the input hash\n");
							return;
						}
						break;
					case 64:
						Console.Write ("Seems a SHA256 Hash, is it? (y/n): ");
						sr = Console.ReadLine ();
						if ((sr.Equals ("y")) || (sr.Equals (""))){
							sw2 = new StreamWriter ("cracked_keys.txt", true);
							string ss = "", h = "";
							stw.Start();
							while ((ss = file.ReadLine()) != null) {
								h = get_sha256 (ss);
								Console.WriteLine ("CHECKING: " + ss + "   SHA256 Hash: " + h);
								if (hc.Equals (h)) {
									Console.WriteLine ("\n\n\nSHA256 CRACKED\n");
									Console.WriteLine ("Password: " + ss + "   SHA256 Hash: " + h);
									sw2.WriteLine ("Password: " + ss + "   SHA256 Hash: " + h);
									sw2.Close ();
									stw.Stop ();
									Console.WriteLine ("\n\nTime Elapsed = {0}", stw.Elapsed);
									Console.WriteLine ("\n\nPress enter to continue . . .");
									Console.ReadLine();
									break;
								}
							}
							stw.Stop ();
							Console.WriteLine ("\n\nTime Elapsed = {0}", stw.Elapsed);
						} else {
							Console.Write ("\nWARNING check the input hash\n");
							return;
						}
						break;
					case 128:
						Console.Write ("Seems a SHA512 Hash, is it? (y/n): ");
						sr = Console.ReadLine ();
						if ((sr.Equals ("y")) || (sr.Equals (""))){
							sw2 = new StreamWriter ("cracked_keys.txt", true);
							string ss = "", h = "";
							stw.Start();
							while ((ss = file.ReadLine()) != null) {
								h = get_sha512 (ss);
								Console.WriteLine ("CHECKING: " + ss + "   SHA512 Hash: " + h);
								if (hc.Equals (h)) {
									Console.WriteLine ("\n\n\nSHA512 CRACKED\n");
									Console.WriteLine ("Password: " + ss + "   SHA512 Hash: " + h);
									sw2.WriteLine ("Password: " + ss + "   SHA512 Hash: " + h);
									sw2.Close ();
									stw.Stop ();
									Console.WriteLine ("\n\nTime Elapsed = {0}", stw.Elapsed);
									Console.WriteLine ("\n\nPress enter to continue . . .");
									Console.ReadLine();
									break;
								}
							}
							stw.Stop ();
						} else {
							Console.Write ("\nWARNING check the input hash\n");
							return;
						}
						break;
					default:
						Console.WriteLine ("WARNING");
						Console.WriteLine (" md5 length must be 32");
						Console.WriteLine (" sha1 length must be 40");
						Console.WriteLine (" sha256 length must be 64");
						Console.WriteLine (" sha512 length must be 128");
						return;
					}
					break;
				case "q":
					Console.WriteLine ("Goodbye");
					return;
				default:
					break;
				}
			}//END WHILE
		}//END run

		public static void help (){
			for(int i = 0; i <= 60; i++){Console.WriteLine ("");}
			Console.WriteLine (c_info);
			Console.WriteLine ("");
			Console.WriteLine ("Usage: crypt4crack [Option] [HashToCrack]");
			Console.WriteLine ("_________________________");
			Console.WriteLine ("");
			Console.WriteLine (" Options");
			Console.WriteLine ("");
			Console.WriteLine ("-v: show current version");
			Console.WriteLine ("-g: to run the gui menu");
			Console.WriteLine ("_________________________");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine (" Options to use with pipes |, recives an input of ");
			Console.WriteLine (" strings, gets the hashes of them and compare with ");
			Console.WriteLine (" the desired hash to crack it and get the source.");
			Console.WriteLine ("");
			Console.WriteLine ("-md5: checks md5, length must be 32");
			Console.WriteLine ("-sha1: checks sha1, length must be 40");
			Console.WriteLine ("-sha256: checks sha256, length must be 64");
			Console.WriteLine ("-sha384: checks sha256, length must be 96");
			Console.WriteLine ("-sha512: checks sha512, length must be 128");
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("_________________________");

		}

		public static void s_version (){


		}

		//return sha-1 hash, recive string
		static string get_sha1(string input)
		{
			using (SHA1Managed sha1 = new SHA1Managed())
			{
				var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
				var sb = new StringBuilder(hash.Length * 2);
				foreach (byte b in hash)
				{
					sb.Append(b.ToString("x2"));
				}
				return sb.ToString();
			}
		}

		//return sha-256 hash, recive string
		static string get_sha256(string input)
		{
			using (SHA256Managed sha256 = new SHA256Managed())
			{
				var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
				var sb = new StringBuilder(hash.Length * 2);
				foreach (byte b in hash)
				{
					sb.Append(b.ToString("x2"));
				}
				return sb.ToString();
			}
		}

		//return sha-384 hash, recive string
		static string get_sha384(string input)
		{
			using (SHA384Managed sha384 = new SHA384Managed())
			{
				var hash = sha384.ComputeHash(Encoding.UTF8.GetBytes(input));
				var sb = new StringBuilder(hash.Length * 2);
				foreach (byte b in hash)
				{
					sb.Append(b.ToString("x2"));
				}
				return sb.ToString();
			}
		}

		//return sha-512 hash, recive string 128length
		static string get_sha512(string input)
		{
			using (SHA512Managed sha512 = new SHA512Managed())
			{
				var hash = sha512.ComputeHash(Encoding.UTF8.GetBytes(input));
				var sb = new StringBuilder(hash.Length * 2);
				foreach (byte b in hash)
				{
					sb.Append(b.ToString("x2"));
				}
				return sb.ToString();
			}
		}


		//return md5 hash, recive string
		public static string get_md5(string source)
		{
			MD5 md5hash = MD5.Create ();
			string h = GetMd5Hash(md5hash, source);
			return(h);
		}

		public static string GetMd5Hash(MD5 md5Hash, string input)
		{
			byte[] d = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < d.Length; i++)
			{
				sb.Append(d[i].ToString("x2"));
			}
			return sb.ToString();
		}

	}//END MAIN
}
