import React, { useState, useEffect } from 'react'
import './table.css';
import Paybutton from './Paybutton';
import axios from 'axios';
import { AtmSharp } from '@material-ui/icons';
import StripeCheckOut from 'react-stripe-checkout';
import  { useHistory } from 'react-router-dom'
import { Button } from 'bootstrap';

const URL = 'https://jsonplaceholder.typicode.com/users'


const QUiz = (props) => {
    const history = useHistory();
    const [courses, setCourses] = useState([]);
    const [startIndex, setStartIndex] =  useState(0);
    const [countedAns, setCountedAnswer] =  useState(0);
    const [attemptedAns, setAttemptedAns] =  useState(1);
    const [countTotalQuiz, setCountTotalQuiz] =  useState(0);
    const [quizAnswer, setquizAnswer] =  useState(null);
    const [error, setError] =  useState(null);
    const [hideBtn, setHideBtn] = useState(true); 

    useEffect(() => {
        async function fetchData() {
            // You can await here
            try {
                const res = await axios.get('/Students/GetAllQuizByTeacherId');
                setCourses(res.data.quizesList);
                setCountedAnswer(res.data.answer);
                setCountTotalQuiz(res.data.total);
                setError(null);
            } catch (ex) {
                setCourses(null);
            }
          }
          fetchData();
    }, []);

    const renderHeader = () => {
        let headerElement = ['Title', 'Option A', 'Option B', 'Option C','Option D', 'Result']
        return headerElement.map((key, index) => {
            return <th key={index}>{key.toUpperCase()}</th>
        });
    }

    const handleQuiz = (async (e) => {
        e.preventDefault();
        if(quizAnswer == null){
            setError("Please un select current answer and then select any answer!");
            return;
        }
        try {
            const postData = {
                startIndex:startIndex+1,
                maxRows: 1,
                selectedAnswer:quizAnswer,
                countedAnswer: countedAns
              };
              setStartIndex(postData.startIndex);
              const res = await axios
              .get('/Students/GetAllQuizByTeacherId?startIndex='+postData.startIndex+"&maxRows="+postData.maxRows+"&SelectedAnswer="+postData.selectedAnswer+"&countedAnswer="+postData.countedAnswer);
            setCourses(res.data.quizesList);
            setCountedAnswer(res.data.answer);
            setCountTotalQuiz(res.data.total);
            setquizAnswer(null);
            setError(null);
            setAttemptedAns(attemptedAns+1);
            if(attemptedAns == countTotalQuiz){
                setHideBtn(false);
            }

        } catch (ex) {
            setCourses(null);
        }
    });

    const renderBody = () => {
        if(courses?.length > 0){
            return courses?.map(data => {
                return  (
                    <tr key={data.userId}>
                        <td style={{ width: '250px' }}>{data.title}</td>
                        <td style={{ width: '200px' }}> 
                            <input onChange={(e) =>{setquizAnswer(e.target.value)}} type="radio" value={data.optionA} name="QUIZ"  />{data.optionA}
                        </td>
                        <td style={{ width: '150px' }}> 
                            <input onChange={(e) =>{setquizAnswer(e.target.value)}} type="radio" value={data.optionB} name="QUIZ" />{data.optionB}
                        </td>
                        <td style={{ width: '150px' }}>
                            <input onChange={(e) =>{setquizAnswer(e.target.value)}} type="radio" value={data.optionC} name="QUIZ" />{data.optionC}
                        </td>
                        <td style={{ width: '150px' }}> 
                            <input onChange={(e) =>{setquizAnswer(e.target.value)}} type="radio" value={data.optionD} name="QUIZ" />{data.optionD}
                        </td>
                        <td style={{ width: '150px' }}> 
                           {countedAns} of {countTotalQuiz}
                        </td>
                    </tr>
                )
            });
        }else{
            return (
                <div style={{color:"red", textAlign: "center"}}>
                   <h1>Final Result is  {countedAns} of {countTotalQuiz}</h1> 
                </div>
            )
        }
    }

    return (
        <div class="tableFixHead">
            <table id='courses'>
                <thead>
                    <tr>{renderHeader()}</tr>
                </thead>
                <tbody>
                    {renderBody()}
                </tbody>
            </table>
            <div>
                {hideBtn && <input type="submit" color="primary" value="Next" onClick={handleQuiz} />} <span style={{color:"red", fontSize: "25px"}}>{error}</span>
            </div>
        </div>
    )
}


export default QUiz