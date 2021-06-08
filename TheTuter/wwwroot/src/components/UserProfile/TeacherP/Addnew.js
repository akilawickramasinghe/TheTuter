import React,{Component} from 'react';
import Form from 'react-bootstrap/Form'
import './Addnew.css';
import Button from 'react-bootstrap/Button';
const axios = require("axios");

export default class Addnew extends React.Component {
 
  constructor(props) {
    super(props);
    this.state = {
      batch: '',
      class: '',
      lesson: '',
      fees: '',
      file: null,
      errorMessage: null,
      sucessMessage: null
    }
  }

render() {
  return(
    <div>
 <Form onSubmit={this.handleSubmit.bind(this)}>

    <h5 class="text-primary" style={{fontWeight:"bold" , marginLeft:"100px"}} >ADD A NEW TUTORIAL</h5>

  <Form.Group className='addnewline' controlId="Batch">
    <Form.Control value={this.state.batch} onChange={this.onBatchChange.bind(this)} type="text" placeholder="Batch" />
    <Form.Text className="text-muted">
    </Form.Text>
  </Form.Group>

  <Form.Group className='addnewline' controlId="Class">
    <Form.Control value={this.state.class} onChange={this.onClassChange.bind(this)} type="text" placeholder="Class" />
  </Form.Group>

  <Form.Group className='addnewline' controlId="Lesson">
    <Form.Control value={this.state.lesson} onChange={this.onLessonChange.bind(this)} type="text" placeholder="Lesson" />
  </Form.Group>

  {/* <Form.Group className='addnewline' controlId="Fee">
    <Form.Control  value={this.state.fees} onChange={this.onFeesChange.bind(this)}  type="text" placeholder="Fee (Rs.)" />
  </Form.Group> */}


  <Form.Group className='addnewline' controlId="File">
    <Form.Control accept=".mp4" type="file" name="file"  onChange={this.onFileChange.bind(this)}   />
  </Form.Group>



  <div style={{marginTop:'20px'}}>
  <Button variant="primary" type="submit">
    Submit
  </Button>
  <span style={{ color: "red", fontSize: "20px", marginLeft: "15px" }}>{this.state.sucessMessage}</span>
  </div>

</Form>

</div>
    )
  }

  onBatchChange(event) {
    this.setState({batch: event.target.value})
  }

  onClassChange(event) {
    this.setState({class: event.target.value})
  }
  
  onLessonChange(event) {
    this.setState({lesson: event.target.value})
  }

 
  onFileChange(event) {
    this.setState({file: event.target.files[0]});
  }
 
  handleSubmit(event) {
    var formData = new FormData();
    event.preventDefault();
    
    if (this.state.batch=='') {
      console.log("please add name");
    } else if (this.state.class=='') {
      console.log("please add lname");
    } else if(this.state.lesson==''){
      console.log("please add email");
    }else{
      const userId = localStorage.getItem('UserId');
      formData.append("userId", userId);
      formData.append("batch", this.state.batch);
      formData.append("class", this.state.class);
      formData.append("lesson", this.state.lesson);
      formData.append("batch", this.state.batch);
      formData.append("batch", this.state.batch);
      formData.append("file", this.state.file, this.state.file.name);
      axios.post('/Teachers/UploadLecture',formData)
      .then((res) => {
        this.setState({sucessMessage: "Tutorials added successfully!"});
        // this.props.history.push("/AccTCRpublished");
      }).catch((err) =>{
       this.setState({errorMessage: err.messsage});
      });
  
    }
    
  }

}