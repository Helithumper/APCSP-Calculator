package com.peyton.calculator.gui;

import java.awt.Dimension;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JPanel;

public class CalculatorFrame extends JFrame implements ActionListener
{
	JPanel nubmersPanel,expressionPanel, outputPanel;
	JButton [] buttons = new JButton [10];
	JButton addButton, subtractButton, divideButton, multButton, modButton;
	JMenuBar menuBar = new JMenuBar();
	JMenu modeMenu = new JMenu();
	JMenuItem calcMode,graphMode;
	
	public CalculatorFrame(){
		for(int i = 0; i < buttons.length; i++){
			buttons[i] = new JButton(i+"");
			
		}
		addButton = new JButton("+");
		subtractButton = new JButton("-");
		multButton = new JButton("*");
		divideButton = new JButton("/");
		modButton = new JButton("%");
		
		menuBar.add(modeMenu);
		calcMode = new JMenuItem("Calculator");
		graphMode = new JMenuItem("Graphing");
		calcMode.addActionListener(this);
		graphMode.addActionListener(this);
		modeMenu.add(calcMode);
		modeMenu.add(graphMode);
		
		menuBar.add(modeMenu);
		
		setJMenuBar(menuBar);
		
		setMinimumSize(new Dimension(350,500));
		setLocationRelativeTo(null);
		setVisible(true);
		
	}
	
	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		
	}
}
