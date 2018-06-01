var CommentBox = React.createClass({
    render: function () {
        return (
            <div className="commentBox">
                Hello there. This is a commentBox.
            </div>
        );
    }
});
ReactDOM.render(
    <CommentBox />,
    document.getElementById('content')
);