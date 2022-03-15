package com.example.bootcamp.sales.requestline;

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

import com.example.bootcamp.sales.request.RequestRepository;

@CrossOrigin
@RestController
@RequestMapping("api/requestline")
public class RequestlineController {

	@Autowired
	private RequestlineRepository requestlineRepo;
	@Autowired
	private RequestRepository requestRepo;
	
	@GetMapping
	public ResponseEntity<Iterable<Requestline>> GetRequestline(){
		var requestline =requestlineRepo.findAll();
		return new ResponseEntity<Iterable<Requestline>>(requestline, HttpStatus.OK);
	}
	
	@GetMapping("{id}")
	public ResponseEntity<Requestline> GetRequestlineById(@PathVariable int id){
	var requestline = requestlineRepo.findById(id);
	if(requestline.isEmpty()) {
		return new ResponseEntity<>(HttpStatus.NOT_FOUND);
	}
		return new ResponseEntity<Requestline>(requestline.get(),HttpStatus.OK);
	}
	
	@PostMapping
	public ResponseEntity<Requestline> PostRequestline(@RequestBody Requestline requestline){
		if (requestline == null || requestline.getId() != 0){
			return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
		}
		var rl1 = requestlineRepo.save(requestline);
		return new ResponseEntity<Requestline>(rl1,HttpStatus.CREATED);
	}
	
	@PutMapping("{id}")
	public ResponseEntity<Requestline> RecalculateRequestline(@RequestBody Requestline requestline, @PathVariable int id) throws Exception{
		if(requestline == null ||requestline.getId()==0) {
			return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
		}
		var reqlOpt = requestlineRepo.findById(requestline.getId());
		if(reqlOpt.isEmpty()) {
			return new ResponseEntity<>(HttpStatus.NOT_FOUND);
		}
		var reql = reqlOpt.get();
		requestlineRepo.save(reql);
		var respEntity = this.recalcRequestTotal(reql.getRequest().getId());
		if(respEntity.getStatusCode() !=HttpStatus.OK) {
			throw new Exception("Recalculate request total failed!");
		}
		return new ResponseEntity<>(HttpStatus.NO_CONTENT);
	}
	
	@SuppressWarnings("rawtypes")
	private ResponseEntity recalcRequestTotal(int requestId) {
		var reqOpt = requestRepo.findById(requestId);
		if(reqOpt.isEmpty()) {
			return new ResponseEntity<>(HttpStatus.NOT_FOUND);
		}
		var request = reqOpt.get();
		var requestTotal = 0;
		for(var requestline : request.getRequestlines()) {
			requestTotal += requestline.getProduct().getPrice() * requestline.getQuantity();
		}
		request.setTotal(requestTotal);
		requestRepo.save(request);
		return new ResponseEntity<>(HttpStatus.OK);
	}
	
	@DeleteMapping("{id}")
	public ResponseEntity<Requestline> DeleteRequestline(@PathVariable int id){
		var requestline = requestlineRepo.findById(id);
	if(requestline.isEmpty()) {
		return new ResponseEntity<>(HttpStatus.NOT_FOUND);
	}
	requestlineRepo.delete(requestline.get());
	return new ResponseEntity<>(HttpStatus.NO_CONTENT);
	
	}
	
}
