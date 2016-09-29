import java.util.ArrayList;
import java.util.List;

public class Player {
	private String name;
	private double balance;
	private List<String> moves = new ArrayList<String>();

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public double getBalance() {
		return balance;
	}

	public void setBalance(double balance) {
		this.balance = balance;
	}
	public boolean updateBalance(double balance) {
		this.balance += balance;
		if(this.balance <= 0){
			return false;
		}
		return true;
	}
	public Player(String name, double balance){
		this.name = name;
		this.balance = balance;
	}

	public List<String> getMoves() {
		return moves;
	}
	
}
