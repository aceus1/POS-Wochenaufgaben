
//Daniel Bauer
//5AHIF
import java.text.SimpleDateFormat;
import java.io.*;
import java.util.Date;

public class HU2main {
	public static Player P1;
	public static String rawFile = "";

	public static void main(String[] args2) {
		String[] args = { "D:\\Schule\\5te klasse\\POS\\160919HUderWoche2Casino8\\Spieler1.conf" };
		int output = 4;
		String putout = "";
		if (args.length > 0) {
			try {
				dateilesen(args[0]);
			} catch (Exception e) {
				e.printStackTrace();
			}
			for (int i = 0; i < P1.getMoves().size(); i++) {
				if (0 != (output = spiel(P1.getMoves().get(i)))) {
					break;
				}
			}
			SimpleDateFormat sdf = new SimpleDateFormat("dd.MM.YYYY HH:mm");
			putout = sdf.format(new Date()) + "Uhr";
			switch (output) {
			case 0:
				putout += " Guthaben " + P1.getBalance() + " Euro";
				break;
			case 1:
				putout += " Spieler pleite";
				break;
			case 2:
				putout += " falsche Betvalue mind. 1 Euro Max 999 Euro";
				break;
			case 3:
				putout += " Spieler pleite"; // Eigentlich versucht er mehr zu
												// setzen als er besitzt, gilt
												// trotzdem als Pleite
				break;
			default:
				break;
			}
			try {
				BufferedWriter BW = new BufferedWriter(new FileWriter(new File(args[0])));
				BW.write(rawFile + "\r\n" + putout);
				BW.close();
			} catch (Exception e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			System.out.println(rawFile + "\r\n" + putout);
		} else {
			System.out.println("This program needs 1 argument - the path of the .conf file.");
		}

	}

	public static int spiel(String move) {// 0 nix passiert, 1 pleite, 2 falsche
											// betvalue, 3 versucht mehr zu
											// setzen als er hat
		String moveA[] = move.split(" ");
		boolean GU = false;// false = ungerade / true = gerade
		int betnumber = -1;
		if (Double.valueOf(moveA[1]) > 999 || Double.valueOf(moveA[1]) < 1) {
			return 2;
		}
		if (Double.valueOf(moveA[1]) > P1.getBalance()) {
			return 3;
		}
		int roulette = (int) (Math.random() * 7 + 0);
		if (!moveA[0].contains("G") && !moveA[0].contains("U")) {
			betnumber = Integer.valueOf(moveA[0]);
		} else if (moveA[0].contains("G")) {
			GU = true;
		}
		if (betnumber == -1) {
			if (roulette != 0 && roulette % 2 == 0 && GU == true) {
				if (!P1.updateBalance(Double.valueOf(moveA[1]) * 2)) {
					return 1;
				}
			} else if (roulette != 0 && roulette % 2 != 0 && GU == false) {
				if (!P1.updateBalance(Double.valueOf(moveA[1]) * 2)) {
					return 1;
				}
			} else {
				if (!P1.updateBalance(-Double.valueOf(moveA[1]))) {
					return 1;
				}
			}
		} else {
			if (betnumber == roulette) {
				if (!P1.updateBalance(Double.valueOf(moveA[1]) * 7)) {
					return 1;
				}
			} else {
				if (!P1.updateBalance(-Double.valueOf(moveA[1]))) {
					return 1;
				}
			}
		}
		return 0;
	}

	public static void dateilesen(String path) throws Exception {
		BufferedReader BR = new BufferedReader(new FileReader(new File(path)));
		String[] fileArr;
		String line = "";
		String fullfile = "";
		do {
			line = BR.readLine();
			fullfile += line + "#";
			rawFile += line + "\r\n";
		} while (line != null);
		fullfile = fullfile.substring(0, fullfile.length() - 6);
		rawFile = rawFile.substring(0, rawFile.length() - 8);
		fileArr = fullfile.split("#");
		/*
		 * for(int i = 0; i < fileArr.length; i++){
		 * System.out.println(fileArr[i] + " " + i); }
		 */
		P1 = new Player(fileArr[0], Double.valueOf(fileArr[1].replace("Startguthaben: ", "")));
		for (int i = 2; i < fileArr.length; i++) {
			if (fileArr[i].contains("ENDE")) {
				break;
			}
			P1.getMoves().add(fileArr[i]);
		}
		BR.close();
	}

}
