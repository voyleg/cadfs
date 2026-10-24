FeatureScript 1511;
import(path : "onshape/std/geometry.fs", version : "1511.0");
import(path : "onshape/std/common.fs", version : "1511.0");
const mm = millimeter;
const VERTEX = EntityType.VERTEX;
const EDGE = EntityType.EDGE;
const FACE = EntityType.FACE;
const BODY = EntityType.BODY;
function v(x, y){return vector(x, y);}
function OD(order){return orderDisambiguation(order);}
function OSD(set){return originalSetDisambiguation(set);}
function TD(topology){return topologyDisambiguation(topology);}
function TDD(query){return trueDependencyDisambiguation(query);}
function sQuery(a, b, c) {return sketchEntityQuery(a, b, c);}

annotation { "Feature Type Name" : "Feature", "Feature Type Description" : "" }
export const myFeature = defineFeature(function(context is Context, id is Id, definition is map)
    precondition{}
    {
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0.bottom", {"start": v(-162.2, 11.19) * mm, "end": v(162.8, 11.19) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(-162.2, -11.81) * mm, "end": v(162.8, -11.81) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(-162.2, 11.19) * mm, "end": v(-162.2, -11.81) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(162.8, 11.19) * mm, "end": v(162.8, -11.81) * mm});
            skCircle(sketch, "E1", {"center": v(0, 0) * mm, "radius": 3.2 * mm});
            skCircle(sketch, "E2", {"center": v(145, 0.69) * mm, "radius": 3.2 * mm});
            skCircle(sketch, "E3", {"center": v(-145, 0.69) * mm, "radius": 3.2 * mm});
            skLineSegment(sketch, "E4", {"start": v(-154.88, 0.69) * mm, "end": v(156.24, 0.69) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F0",true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 10.2 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.bottom")])]});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E5", {"start": v(0, 0) * mm, "end": v(0, -26.9) * mm, "construction": true});
            skLineSegment(sketch, "E6", {"start": v(-95, 0) * mm, "end": v(-95, -23.36) * mm, "construction": true});
            skLineSegment(sketch, "E7", {"start": v(95, 0) * mm, "end": v(95, -29.38) * mm, "construction": true});
            skSolve(sketch);
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E0.bottom");Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([subQ0])],"isStart":true})}),-1.0]])]});}
            var sketch = newSketch(context, id + "F3", { "sketchPlane" : qUnion([Q0])});
            skText(sketch, "E8", { "text": "CHICKEN", "fontName": "OpenSans-Bold.ttf"});
            skText(sketch, "E9", { "text": "CHICKEN", "fontName": "OpenSans-Bold.ttf"});
            skText(sketch, "E10", { "text": "CHICKEN", "fontName": "OpenSans-Bold.ttf"});
            const initialGuessF3  = {"E8": [-0.12506, -0.0099, 1, 0, 0.0099], "E9": [-0.03022, -0.01007, 1, 0, 0.0099], "E10": [0.06503, -0.01002, 1, 0, 0.0099]};
            skSetInitialGuess(sketch, initialGuessF3);
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F3",true);
            extrude(context, id + "F4", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 2 * mm, "hasDraft" : true, "draftAngle" : 5 * degree, "draftPullDirection" : true});
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E0.bottom");Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([subQ0])],"isStart":true})}),-1.0]])]});}
            var sketch = newSketch(context, id + "F5", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E11.MirrorCS", {"start": v(35.19, 0) * mm, "end": v(32.19, 0) * mm});
            skLineSegment(sketch, "E12.MirrorCS", {"start": v(35.19, -10.2) * mm, "end": v(32.19, -10.2) * mm});
            skLineSegment(sketch, "E13.MirrorCS", {"start": v(32.19, 0) * mm, "end": v(32.19, -10.2) * mm});
            skLineSegment(sketch, "E14.MirrorCS", {"start": v(35.19, 0) * mm, "end": v(35.19, -10.2) * mm});
            skLineSegment(sketch, "E15.MirrorCS", {"start": v(130.44, -10.2) * mm, "end": v(127.44, -10.2) * mm});
            skLineSegment(sketch, "E16.MirrorCS", {"start": v(130.44, 0) * mm, "end": v(127.44, 0) * mm});
            skLineSegment(sketch, "E17.MirrorCS", {"start": v(127.44, 0) * mm, "end": v(127.44, -10.2) * mm});
            skLineSegment(sketch, "E18.MirrorCS", {"start": v(130.44, 0) * mm, "end": v(130.44, -10.2) * mm});
            skLineSegment(sketch, "E19.MirrorCS", {"start": v(-126.49, 0) * mm, "end": v(-126.49, -10.2) * mm});
            skLineSegment(sketch, "E20.MirrorCS", {"start": v(-129.49, 0) * mm, "end": v(-129.49, -10.18) * mm});
            skLineSegment(sketch, "E21.MirrorCS", {"start": v(-129.49, 0) * mm, "end": v(-126.49, 0) * mm});
            skLineSegment(sketch, "E22.1.0.0", {"start": v(137.44, -10.2) * mm, "end": v(134.44, -10.2) * mm});
            skLineSegment(sketch, "E22.1.0.1", {"start": v(137.44, 0) * mm, "end": v(137.44, -10.2) * mm});
            skLineSegment(sketch, "E22.1.0.2", {"start": v(137.44, 0) * mm, "end": v(134.44, 0) * mm});
            skLineSegment(sketch, "E22.1.0.3", {"start": v(134.44, 0) * mm, "end": v(134.44, -10.2) * mm});
            skLineSegment(sketch, "E22.2.0.0", {"start": v(144.44, -10.2) * mm, "end": v(141.44, -10.2) * mm});
            skLineSegment(sketch, "E22.2.0.1", {"start": v(144.44, 0) * mm, "end": v(144.44, -10.2) * mm});
            skLineSegment(sketch, "E22.2.0.2", {"start": v(144.44, 0) * mm, "end": v(141.44, 0) * mm});
            skLineSegment(sketch, "E22.2.0.3", {"start": v(141.44, 0) * mm, "end": v(141.44, -10.2) * mm});
            skLineSegment(sketch, "E22.3.0.0", {"start": v(151.44, -10.2) * mm, "end": v(148.44, -10.2) * mm});
            skLineSegment(sketch, "E22.3.0.1", {"start": v(151.44, 0) * mm, "end": v(151.44, -10.2) * mm});
            skLineSegment(sketch, "E22.3.0.2", {"start": v(151.44, 0) * mm, "end": v(148.44, 0) * mm});
            skLineSegment(sketch, "E22.3.0.3", {"start": v(148.44, 0) * mm, "end": v(148.44, -10.2) * mm});
            skLineSegment(sketch, "E22.4.0.0", {"start": v(158.44, -10.2) * mm, "end": v(155.44, -10.2) * mm});
            skLineSegment(sketch, "E22.4.0.1", {"start": v(158.44, 0) * mm, "end": v(158.44, -10.2) * mm});
            skLineSegment(sketch, "E22.4.0.2", {"start": v(158.44, 0) * mm, "end": v(155.44, 0) * mm});
            skLineSegment(sketch, "E22.4.0.3", {"start": v(155.44, 0) * mm, "end": v(155.44, -10.2) * mm});
            skLineSegment(sketch, "E22.direction1", {"start": v(127.44, -10.2) * mm, "end": v(134.44, -10.2) * mm, "construction": true});
            skLineSegment(sketch, "E23.1.0.0", {"start": v(39.19, 0) * mm, "end": v(39.19, -10.2) * mm});
            skLineSegment(sketch, "E23.1.0.1", {"start": v(42.19, 0) * mm, "end": v(42.19, -10.2) * mm});
            skLineSegment(sketch, "E23.1.0.2", {"start": v(42.19, -10.2) * mm, "end": v(39.19, -10.2) * mm});
            skLineSegment(sketch, "E23.1.0.3", {"start": v(42.19, 0) * mm, "end": v(39.19, 0) * mm});
            skLineSegment(sketch, "E23.2.0.0", {"start": v(46.19, 0) * mm, "end": v(46.19, -10.2) * mm});
            skLineSegment(sketch, "E23.2.0.1", {"start": v(49.19, 0) * mm, "end": v(49.19, -10.2) * mm});
            skLineSegment(sketch, "E23.2.0.2", {"start": v(49.19, -10.2) * mm, "end": v(46.19, -10.2) * mm});
            skLineSegment(sketch, "E23.2.0.3", {"start": v(49.19, 0) * mm, "end": v(46.19, 0) * mm});
            skLineSegment(sketch, "E23.3.0.0", {"start": v(53.19, 0) * mm, "end": v(53.19, -10.2) * mm});
            skLineSegment(sketch, "E23.3.0.1", {"start": v(56.19, 0) * mm, "end": v(56.19, -10.2) * mm});
            skLineSegment(sketch, "E23.3.0.2", {"start": v(56.19, -10.2) * mm, "end": v(53.19, -10.2) * mm});
            skLineSegment(sketch, "E23.3.0.3", {"start": v(56.19, 0) * mm, "end": v(53.19, 0) * mm});
            skLineSegment(sketch, "E23.4.0.0", {"start": v(60.19, 0) * mm, "end": v(60.19, -10.2) * mm});
            skLineSegment(sketch, "E23.4.0.1", {"start": v(63.19, 0) * mm, "end": v(63.19, -10.2) * mm});
            skLineSegment(sketch, "E23.4.0.2", {"start": v(63.19, -10.2) * mm, "end": v(60.19, -10.2) * mm});
            skLineSegment(sketch, "E23.4.0.3", {"start": v(63.19, 0) * mm, "end": v(60.19, 0) * mm});
            skLineSegment(sketch, "E23.direction1", {"start": v(32.19, -10.2) * mm, "end": v(39.19, -10.2) * mm, "construction": true});
            skLineSegment(sketch, "E24", {"start": v(-126.49, -10.2) * mm, "end": v(-129.49, -10.18) * mm});
            skLineSegment(sketch, "E25.1.0.0", {"start": v(-133.49, 0) * mm, "end": v(-133.49, -10.2) * mm});
            skLineSegment(sketch, "E25.1.0.1", {"start": v(-136.49, 0) * mm, "end": v(-136.49, -10.18) * mm});
            skLineSegment(sketch, "E25.1.0.2", {"start": v(-133.49, -10.2) * mm, "end": v(-136.49, -10.18) * mm});
            skLineSegment(sketch, "E25.1.0.3", {"start": v(-136.49, 0) * mm, "end": v(-133.49, 0) * mm});
            skLineSegment(sketch, "E25.2.0.0", {"start": v(-140.49, 0) * mm, "end": v(-140.49, -10.2) * mm});
            skLineSegment(sketch, "E25.2.0.1", {"start": v(-143.49, 0) * mm, "end": v(-143.49, -10.18) * mm});
            skLineSegment(sketch, "E25.2.0.2", {"start": v(-140.49, -10.2) * mm, "end": v(-143.49, -10.18) * mm});
            skLineSegment(sketch, "E25.2.0.3", {"start": v(-143.49, 0) * mm, "end": v(-140.49, 0) * mm});
            skLineSegment(sketch, "E25.3.0.0", {"start": v(-147.49, 0) * mm, "end": v(-147.49, -10.2) * mm});
            skLineSegment(sketch, "E25.3.0.1", {"start": v(-150.49, 0) * mm, "end": v(-150.49, -10.18) * mm});
            skLineSegment(sketch, "E25.3.0.2", {"start": v(-147.49, -10.2) * mm, "end": v(-150.49, -10.18) * mm});
            skLineSegment(sketch, "E25.3.0.3", {"start": v(-150.49, 0) * mm, "end": v(-147.49, 0) * mm});
            skLineSegment(sketch, "E25.4.0.0", {"start": v(-154.49, 0) * mm, "end": v(-154.49, -10.2) * mm});
            skLineSegment(sketch, "E25.4.0.1", {"start": v(-157.49, 0) * mm, "end": v(-157.49, -10.18) * mm});
            skLineSegment(sketch, "E25.4.0.2", {"start": v(-154.49, -10.2) * mm, "end": v(-157.49, -10.18) * mm});
            skLineSegment(sketch, "E25.4.0.3", {"start": v(-157.49, 0) * mm, "end": v(-154.49, 0) * mm});
            skLineSegment(sketch, "E25.direction1", {"start": v(-129.49, -10.18) * mm, "end": v(-136.49, -10.18) * mm, "construction": true});
            skLineSegment(sketch, "E26.bottom", {"start": v(-62.65, 0) * mm, "end": v(-59.65, 0) * mm});
            skLineSegment(sketch, "E26.top", {"start": v(-62.65, -10.2) * mm, "end": v(-59.65, -10.2) * mm});
            skLineSegment(sketch, "E26.left", {"start": v(-62.65, 0) * mm, "end": v(-62.65, -10.2) * mm});
            skLineSegment(sketch, "E26.right", {"start": v(-59.65, 0) * mm, "end": v(-59.65, -10.2) * mm});
            skLineSegment(sketch, "E27.1.0.0", {"start": v(-52.65, 0) * mm, "end": v(-52.65, -10.2) * mm});
            skLineSegment(sketch, "E27.1.0.1", {"start": v(-55.65, 0) * mm, "end": v(-55.65, -10.2) * mm});
            skLineSegment(sketch, "E27.1.0.2", {"start": v(-55.65, -10.2) * mm, "end": v(-52.65, -10.2) * mm});
            skLineSegment(sketch, "E27.1.0.3", {"start": v(-55.65, 0) * mm, "end": v(-52.65, 0) * mm});
            skLineSegment(sketch, "E27.2.0.0", {"start": v(-45.65, 0) * mm, "end": v(-45.65, -10.2) * mm});
            skLineSegment(sketch, "E27.2.0.1", {"start": v(-48.65, 0) * mm, "end": v(-48.65, -10.2) * mm});
            skLineSegment(sketch, "E27.2.0.2", {"start": v(-48.65, -10.2) * mm, "end": v(-45.65, -10.2) * mm});
            skLineSegment(sketch, "E27.2.0.3", {"start": v(-48.65, 0) * mm, "end": v(-45.65, 0) * mm});
            skLineSegment(sketch, "E27.3.0.0", {"start": v(-38.65, 0) * mm, "end": v(-38.65, -10.2) * mm});
            skLineSegment(sketch, "E27.3.0.1", {"start": v(-41.65, 0) * mm, "end": v(-41.65, -10.2) * mm});
            skLineSegment(sketch, "E27.3.0.2", {"start": v(-41.65, -10.2) * mm, "end": v(-38.65, -10.2) * mm});
            skLineSegment(sketch, "E27.3.0.3", {"start": v(-41.65, 0) * mm, "end": v(-38.65, 0) * mm});
            skLineSegment(sketch, "E27.4.0.0", {"start": v(-31.65, 0) * mm, "end": v(-31.65, -10.2) * mm});
            skLineSegment(sketch, "E27.4.0.1", {"start": v(-34.65, 0) * mm, "end": v(-34.65, -10.2) * mm});
            skLineSegment(sketch, "E27.4.0.2", {"start": v(-34.65, -10.2) * mm, "end": v(-31.65, -10.2) * mm});
            skLineSegment(sketch, "E27.4.0.3", {"start": v(-34.65, 0) * mm, "end": v(-31.65, 0) * mm});
            skLineSegment(sketch, "E27.direction1", {"start": v(-59.65, -10.2) * mm, "end": v(-52.65, -10.2) * mm, "construction": true});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F5", true);
            extrude(context, id + "F6", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 2 * mm, "hasDraft" : true, "draftAngle" : 5 * degree, "draftPullDirection" : true});
        }
    });