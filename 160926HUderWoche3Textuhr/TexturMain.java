import java.util.Date;
import java.text.SimpleDateFormat;
//Status: fertig

public class TexturMain {
	private static String[] TimeList = { null, "Ein", "Zwei", "Drei", "Vier", "Fünf", "Sechs", "Sieben", "Acht", "Neun",
			"Zehn", "Elf", "Zwölf", "Dreizehn", "Vierzehn", "Fünfzehn", "Sechszehn", "Siebzehn", "Achtzehn", "Neunzehn",
			"Zwanzig", "Einundzwanzig", "Zweiundzwanzig", "Dreiundzwanzig", "Vierundzwanzig", "Fünfundzwanzig",
			"Sechsundzwanzig", "Siebenundzwanzig", "Achtundzwanzig", "Neunundzwanzig", "Dreißig", "Einunddreißig",
			"Zweiunddreißig", "Dreiunddreißig", "Vierunddreißig", "Fünfunddreißig", "Sechsunddreißig",
			"Siebenunddreißig", "Achtunddreißig", "Neununddreißig", "Vierzig", "Einundvierzig", "Zweiundvierzig",
			"Dreiundvierzig", "Vierundvierzig", "Fünfundvierzig", "Sechsundvierzig", "Siebenundvierzig",
			"Achtundvierzig", "Neunundvierzig", "Fünfzig", "Einundfünfzig", "Zweiundfünfzig", "Dreiundfünfzig",
			"Vierundfünfzig", "Fünfundfünfzig", "Sechsundfünfzig", "Siebenundfünfzig", "Achtundfünfzig",
			"Neunundfünfzig", "Sechzig" };

	public static void main(String[] args) {
		do {
			try {
				System.out.println(ZeitInText(new Date()));
				Thread.sleep(1000);
			} catch (Exception e) {
				System.out.println(e.getMessage());
			}
		} while (true);
	}

	private static String ZeitInText(Date time) {
		String[] tmp = new SimpleDateFormat("HH:mm:ss").format(new Date().getTime()).split(":");
		return TimeList[Integer.valueOf(tmp[0])] + " Uhr " + TimeList[Integer.valueOf(tmp[1])] + " und " + TimeList[Integer.valueOf(tmp[2])] + " Sekunden";
	}

}
