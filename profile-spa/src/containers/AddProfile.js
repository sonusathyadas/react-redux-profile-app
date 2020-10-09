import {AddProfile } from '../components/AddProfile';
import {bindActionCreators} from 'redux';
import {connect} from 'react-redux';
import { saveProfile } from '../actions/profile-actions';
import {withRouter} from 'react-router-dom'


function matchDispatchToProps(dispatch){
    let actionMap={
        addProfile:saveProfile
    };
    return bindActionCreators(actionMap, dispatch);
}

export default withRouter(connect(null, matchDispatchToProps)(AddProfile));