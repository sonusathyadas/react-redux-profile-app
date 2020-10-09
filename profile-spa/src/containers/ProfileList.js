import { ProfileList } from '../components/ProfileList';
import {connect} from 'react-redux';
import {bindActionCreators} from 'redux';
import { fetchProfiles} from '../actions/profile-actions';

function mapStateToProps(state) {
    return {
        profiles: state.profiles
    };
}

function matchDispatchToProps(dispatch){
    let actionMap={
        fetchProfiles
    };
    return bindActionCreators(actionMap, dispatch);
}

export default connect(mapStateToProps, matchDispatchToProps)(ProfileList);