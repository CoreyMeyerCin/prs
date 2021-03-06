package com.example.bootcamp.sales.request;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@CrossOrigin
@RestController
@RequestMapping("api/requests")
public class RequestController {

	@Autowired
	private RequestRepository requestRepo;
	
	@GetMapping("review/{userId}")
	public ResponseEntity<Iterable<Request>> GetReviews(@PathVariable int userId){
		var requests = requestRepo.findAll();
		for(Request currentReq : requests) 
			if(currentReq.getStatus()=="REVIEW" && currentReq.getUser().getId() != userId){
				return new ResponseEntity<Iterable<Request>>(requests, HttpStatus.OK);
			}
			return new ResponseEntity<>(HttpStatus.NOT_FOUND);
	}
	
	
	@GetMapping
	public ResponseEntity<Iterable<Request>> GetRequest(){
		var requests =requestRepo.findAll();
		return new ResponseEntity<Iterable<Request>>(requests, HttpStatus.OK);
	}
	
	@GetMapping("{id}")
	public ResponseEntity<Request> GetRequestById(@PathVariable int id){
	var request = requestRepo.findById(id);
	if(request.isEmpty()) {
		return new ResponseEntity<>(HttpStatus.NOT_FOUND);
	}
		return new ResponseEntity<Request>(request.get(),HttpStatus.OK);
	}
	
	@PostMapping
	public ResponseEntity<Request> PostRequest(@RequestBody Request request){
		if (request == null || request.getId() != 0){
			return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
		}
		var r1 =requestRepo.save(request);
		return new ResponseEntity<Request>(r1,HttpStatus.CREATED);
	}
	
	@PutMapping("{id}/review")
	public ResponseEntity<Request> ReviewRequest(@RequestBody Request request, @PathVariable int id) {
		if (request == null || request.getId()==0) {
			return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
		}
		var r1 = requestRepo.findById(id);
		if (r1.isEmpty()) {
			return new ResponseEntity<>(HttpStatus.NOT_FOUND);
		}
		if(r1.get().getTotal() >= 50) {
			r1.get().setStatus("APPROVED");
			return new ResponseEntity<>(HttpStatus.NO_CONTENT);
		}
		r1.get().setStatus("REVIEW");
		return new ResponseEntity<>(HttpStatus.NO_CONTENT);
	}
	
	@PutMapping("{id}/reject")
	public ResponseEntity<Request> RejectRequest(@RequestBody Request request, @PathVariable int id){
		if(request == null || request.getId() ==0) {
			return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
		}
		var r1 = requestRepo.findById(id);
		if(r1.isEmpty()) {
			return new ResponseEntity<>(HttpStatus.NOT_FOUND);
		}
		r1.get().setStatus("REJECTED"); 
		return new ResponseEntity<>(HttpStatus.NO_CONTENT);
	}
	
	@PutMapping("{id}/approve")
	public ResponseEntity<Request> ApproveRequest(@RequestBody Request request, @PathVariable int id){
		if(request == null || request.getId() ==0) {
			return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
		}
		var r1 = requestRepo.findById(id);
		if(r1.isEmpty()) {
			return new ResponseEntity<>(HttpStatus.NOT_FOUND);
		}
		r1.get().setStatus("APPROVED"); 
		return new ResponseEntity<>(HttpStatus.NO_CONTENT);
	}
	
	
	@PutMapping("{id}")
	public ResponseEntity<Request> PutRequest(@RequestBody Request request, @PathVariable int id){
		if(request == null || request.getId()==0) {
			return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
		}
		var r1 = requestRepo.findById(id);
		if(r1.isEmpty()) {
			return new ResponseEntity<>(HttpStatus.NOT_FOUND);
		}
		requestRepo.save(request);
		return new ResponseEntity<>(HttpStatus.NO_CONTENT);
	}
	@DeleteMapping("{id}")
	public ResponseEntity<Request> DeleteRequest(@PathVariable int id){
		var request = requestRepo.findById(id);
	if(request.isEmpty()) {
		return new ResponseEntity<>(HttpStatus.NOT_FOUND);
	}
	requestRepo.delete(request.get());
	return new ResponseEntity<>(HttpStatus.NO_CONTENT);
	
	}
	
}
