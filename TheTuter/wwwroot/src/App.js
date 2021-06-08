import './App.css';
import { BrowserRouter, Switch,Route} from 'react-router-dom';
import Home from './components/Home/Home'
import TeacherR from './components/Register/TeacherR';
import StudentR2 from './components/Register/StudentR2';
import AccSTmenu from './components/UserProfile/StudentP/AccSTmenu';
import AccSTQuiz from './components/UserProfile/StudentP/AccSTQuiz';
import AccSTsubscriptions from './components/UserProfile/StudentP/AccSTsubscriptions';
import About from './components/About/About';
import Institute from './components/Institute/Institute';
import Contact from './components/Contact/Contact';
import AccTCRaddnew from './components/UserProfile/TeacherP/AccTCRaddnew';
import AccTCRaddquiz from './components/UserProfile/TeacherP/AccTCRaddquiz';
import AccTCRpublished from './components/UserProfile/TeacherP/AccTCRpublished';


function App() {

  return (
    <BrowserRouter>
      <div className="App">
         <Switch>
            <Route path="/" exact component={Home} />
            <Route path="/teacherR"  component={TeacherR} />
            <Route path="/studentR2"  component={StudentR2} />
            <Route path='/accSTsubscriptions'  component={AccSTsubscriptions} />
            <Route path="/accSTmenu"  component={AccSTmenu} />
            <Route path="/AccSTQuiz"  component={AccSTQuiz} />
            <Route path="/home"  component={Home} />
            <Route path="/about"  component={About} />
            <Route path="/institute"  component={Institute} />
            <Route path="/contact"  component={ Contact} />
            <Route path='/AccTCRaddnew'  component={AccTCRaddnew} />
            <Route path='/AccTCRaddquiz'  component={AccTCRaddquiz} />
            <Route path='/AccTCRpublished'  component={AccTCRpublished} />
       </Switch>
    </div>
    </BrowserRouter> 
  );
}

export default App;


 