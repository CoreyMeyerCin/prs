package com.example.bootcamp.sales.request;

import javax.persistence.*;

import com.example.bootcamp.sales.requestline.Requestline;
import com.example.bootcamp.sales.user.User;
import com.fasterxml.jackson.annotation.JsonBackReference;
import com.fasterxml.jackson.annotation.JsonManagedReference;

import java.util.List;

@Entity

public class Request {
	@Id	
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	 public int id;
	@Column(length=100, nullable=false)
     private String description ;
	@Column(length=30, nullable=false)
     private String justification;
	@Column(length=30, nullable=true)
     private String rejectionReason;
	@Column(length=30, nullable=false)
     private String deliveryMode;
	@Column(length=30, nullable=false)
     private String status = "NEW";
	@Column(columnDefinition="decimal(9,2) NOT NULL DEFAULT 0.0")
     private double total;

	@JsonBackReference
     @ManyToOne(optional=false)
     @JoinColumn(name="userId")
     private User user;
	
	@JsonManagedReference
    @OneToMany(mappedBy="request")
    private List<Requestline> requestlines;
	
     ///////////////////////////////
     public Request() {}
     
     
     
     /////////////////////////////////////////
     public List<Requestline> getRequestlines() {
 		return requestlines;
 	}
     
 	public void setRequestlines(List<Requestline> requestlines) {
 		this.requestlines = requestlines;
 	}
     
	public int getId() {
		return id;
	}


	public void setId(int id) {
		this.id = id;
	}
	public String getDescription() {
		return description;
	}
	public void setDescription(String description) {
		this.description = description;
	}
	public String getJustification() {
		return justification;
	}
	public void setJustification(String justification) {
		this.justification = justification;
	}
	public String getRejectionReason() {
		return rejectionReason;
	}
	public void setRejectionReason(String rejectionReason) {
		this.rejectionReason = rejectionReason;
	}
	public String getDeliveryMode() {
		return deliveryMode;
	}
	public void setDeliveryMode(String deliveryMode) {
		this.deliveryMode = deliveryMode;
	}
	public String getStatus() {
		return status;
	}
	public void setStatus(String status) {
		this.status = status;
	}
	public double getTotal() {
		return total;
	}
	public void setTotal(double total) {
		this.total = total;
	}
	public User getUser() {
		return user;
	}
	public void setUser(User user) {
		this.user = user;
	}
     
     ////////////////////////
     
}
