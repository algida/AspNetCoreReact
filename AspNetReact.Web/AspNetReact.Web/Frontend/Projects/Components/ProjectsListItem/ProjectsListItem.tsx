import * as React from 'react';
import * as moment from 'moment';

import './ProjectsListItem.scss';
import Project from '../../Models/Project';

interface ProjectsListItemProps {
	key: number,
	project: Project
}

class ProjectsListItem extends React.Component<ProjectsListItemProps, any> {

	render() {
		return (
			<a href={`/Projects/Details/${this.props.project.id}`}>
				<div className='ProjectsListItem row'>
					<div className='col-md-12'>
						<div className='ProjectsListItem-summary row'>
							<div className='col-md-6 padding-none'>
								<span className='ProjectsListItem-name'>{this.props.project.name}</span>
							</div>
							<div className='col-md-6 padding-none'>
								<span className='pull-right'>
									<span className='glyphicon glyphicon-calendar'></span> {moment(this.props.project.creationDate).format("DD-MM-YYYY")}
								</span>
							</div>
						</div>
						<div className='row'>
							<div className='col-md-12 padding-none'>
								<span className='ProjectsListItem-description'>{this.props.project.description}</span>
							</div>
						</div>
					</div>
				</div>
			</a>
		)
	}

}

export default ProjectsListItem;