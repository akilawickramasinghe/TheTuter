import React,{Component} from 'react';
import Form from 'react-bootstrap/Form'
import './Addnew.css';
import Button from 'react-bootstrap/Button';
const axios = require("axios");

export default class AddQuiz extends React.Component {
  
    constructor(props) {
        super(props);
        this.state = {
          subject: '',
          title: '',
          optionA: '',
          optionB: '',
          optionC: '',
          optionD: '',
          answer: '',
          errorMessage: null,
          sucessMessage: null,
        };
      }

      render() {
        return(
          <div>
       <Form onSubmit={this.handleSubmit.bind(this)}>
          <h5 class="text-primary" style={{fontWeight:"bold" , marginLeft:"100px"}} >ADD A NEW QUIZES</h5>
        <Form.Group className='addnewline' controlId="Subject">
          <Form.Control value={this.state.subject} onChange={this.onSubjectChange.bind(this)} type="text" placeholder="Subject" />
          <Form.Text className="text-muted">
          </Form.Text>
        </Form.Group>
      
        <Form.Group className='addnewline' controlId="Title">
          <Form.Control value={this.state.title} onChange={this.onTitleChange.bind(this)} type="text" placeholder="Question" />
        </Form.Group>
      
        <Form.Group className='addnewline' controlId="OptionA">
          <Form.Control value={this.state.optionA} onChange={this.onOptionAChange.bind(this)} type="text" placeholder="Option A" />
        </Form.Group>
      
        <Form.Group className='addnewline' controlId="OptionB">
          <Form.Control value={this.state.optionB} onChange={this.onOptionBChange.bind(this)} type="text" placeholder="Option B" />
        </Form.Group>
      
        <Form.Group className='addnewline' controlId="OptionC">
          <Form.Control value={this.state.optionC} onChange={this.onOptionCChange.bind(this)} type="text" placeholder="Option C" />
        </Form.Group>
      
        <Form.Group className='addnewline' controlId="OptionD">
          <Form.Control value={this.state.optionD} onChange={this.onOptionDChange.bind(this)} type="text" placeholder="Option D" />
        </Form.Group>
      
        <Form.Group className='addnewline' controlId="Answer">
          <Form.Control value={this.state.answer} onChange={this.onAnswerChange.bind(this)} type="text" placeholder="Correct Answer" />
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

        onSubjectChange(event) {
            this.setState({subject: event.target.value})
          }
        
          onTitleChange(event) {
            this.setState({title: event.target.value})
          }
          
          onOptionAChange(event) {
            this.setState({optionA: event.target.value})
          }
          onOptionBChange(event) {
            this.setState({optionB: event.target.value})
          }
          onOptionCChange(event) {
            this.setState({optionC: event.target.value})
          }
          onOptionDChange(event) {
            this.setState({optionD: event.target.value})
          }
          onAnswerChange(event) {
            this.setState({answer: event.target.value})
          }
        

  handleSubmit(event) {
    var formData = new FormData();
    event.preventDefault();

    if (this.state.subject=='') {
      console.log("please add subject name");
    } else if (this.state.title=='') {
      console.log("please add quiz title");
    } else if(this.state.optionA==''){
      console.log("please add option A");
    }else if(this.state.optionB==''){
        console.log("please add option B");
      }else if(this.state.optionC==''){
        console.log("please add option C");
      }else if(this.state.optionD==''){
        console.log("please add option D");
      }else if(this.state.answer==''){
        console.log("please add correct answer");
      }
    else{
      const userId = localStorage.getItem('UserId');
      formData.append("userId", userId);
      formData.append("subject", this.state.subject);
      formData.append("title", this.state.title);
      formData.append("optionA", this.state.optionA);
      formData.append("optionB", this.state.optionB);
      formData.append("optionC", this.state.optionC);
      formData.append("optionD", this.state.optionD);
      formData.append("answer", this.state.answer);
      axios.post('/Teachers/UploadQuizes',formData )
      .then((res) => {
        this.setState({sucessMessage: "Question added successfully!"});
        // this.props.history.push('/AccTCRpublished/');
        this.props.history.push("/AccTCRpublished");
      }).catch((err) =>{
       this.setState({errorMessage: err.messsage});
      });
  
    }
    
  }

}