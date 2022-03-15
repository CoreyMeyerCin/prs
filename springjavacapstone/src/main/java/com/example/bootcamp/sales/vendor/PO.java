package com.example.bootcamp.sales.vendor;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;

@Entity

public class PO {
	
	
	   @ManyToOne(optional=false)
	    @JoinColumn(name="vendorId")
	public Vendor vendor;
	
	   @ManyToOne(optional=false)
	    @JoinColumn(name="requestId")
	public Iterable<PoLine> Polines;
	
	   @Column(columnDefinition="decimal(9,2) NOT NULL DEFAULT 0.0")
	public double PoTotal;
	   ////////////////////////////////////////////
	   public PO () {}
	   //////////////////////////////////////////////
	public Vendor getVendor() {
		return vendor;
	}
	public void setVendor(Vendor vendor) {
		this.vendor = vendor;
	}
	public Iterable<PoLine> getPolines() {
		return Polines;
	}
	public void setPolines(Iterable<PoLine> polines) {
		Polines = polines;
	}
	public double getPoTotal() {
		return PoTotal;
	}
	public void setPoTotal(double poTotal) {
		PoTotal = poTotal;
	}
	   
	   
}
